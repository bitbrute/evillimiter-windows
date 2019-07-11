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
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EvilLimiter.Windows.Networking
{
    public class HostScanner
    {
        public bool IsScanning { get; private set; }


        private readonly NetworkInformation _networkInfo;

        private int _totalScans;
        private int _finishedScans;
        private CancellationTokenSource _tokenSource;


        #region Events

        // IMPORTANT: All events are fired from a thread different from the main thread

        public event EventHandler<ScanFinishedEventArgs> ScanFinished;
        private void OnScanFinished(ScanFinishedEventArgs e)
            => ScanFinished?.Invoke(this, e);

        public event EventHandler<HostScannedEventArgs> HostScanned;
        private void OnHostScanned(HostScannedEventArgs e)
            => HostScanned?.Invoke(this, e);

        #endregion



        public HostScanner(NetworkInformation netInfo)
        {
            this._networkInfo = netInfo;
        }



        public void Scan(ICollection<IpV4Address> addresses)
        {
            if (IsScanning)
                return;

            IsScanning = true;
            _totalScans = addresses.Count;
            _finishedScans = 0;

            var sourceAddress = ((IpV4SocketAddress)_networkInfo.InterfaceAddress.Address).Address;
            var sourcePhysicalAddress = _networkInfo.Interface.GetNetworkInterface().GetPhysicalAddress();

            _tokenSource = new CancellationTokenSource();
            var cancellationToken = _tokenSource.Token;
            var discoveredHosts = new List<Host>();

            Task.Run(() =>
            {
                while (true)
                {
                    if (cancellationToken.IsCancellationRequested)
                        break;

                    _networkInfo.Communicator.ReceivePacket(out Packet p);

                    if (!cancellationToken.IsCancellationRequested &&
                        p != null &&
                        p.IsValid &&
                        p.Ethernet.IsValid &&
                        p.Ethernet.EtherType == EthernetType.Arp &&
                        p.Ethernet.Arp.IsValid &&
                        p.Ethernet.Arp.Operation == ArpOperation.Reply &&
                        addresses.Contains(p.Ethernet.Arp.SenderProtocolIpV4Address) &&
                        p.Ethernet.Arp.TargetProtocolIpV4Address == sourceAddress)
                    {
                        var host = new Host(
                            p.Ethernet.Arp.SenderProtocolIpV4Address,
                            new MacAddress(BitConverter.ToString(p.Ethernet.Arp.SenderHardwareAddress.ToArray()).Replace('-', ':'))
                        );

                        if (!discoveredHosts.Contains(host))
                            discoveredHosts.Add(host);
                    }
                }
            }, cancellationToken);

            Task.Run(() =>
            {
                foreach (var addr in addresses)
                {
                    var packet = PacketBuilder.Build(
                        DateTime.Now,
                        new EthernetLayer()
                        {
                            EtherType = EthernetType.None,
                            Source = NetworkUtilities.PhysicalAddressToMacAddress(sourcePhysicalAddress),
                            Destination = NetworkUtilities.BroadcastMac,
                        },
                        new ArpLayer()
                        {
                            ProtocolType = EthernetType.IpV4,
                            Operation = ArpOperation.Request,
                            SenderProtocolAddress = sourceAddress.ToBytes(),
                            SenderHardwareAddress = sourcePhysicalAddress.GetAddressBytes().AsReadOnly(),
                            TargetProtocolAddress = addr.ToBytes(),
                            TargetHardwareAddress = MacAddress.Zero.ToBytes(),
                        }
                    );

                    _networkInfo.Communicator.SendPacket(packet);

                    if (cancellationToken.IsCancellationRequested)
                        break;

                    Interlocked.Increment(ref _finishedScans);
                    OnHostScanned(new HostScannedEventArgs(_totalScans, _finishedScans));

                    Thread.Sleep(Config.ScanSendInterval);
                }

                if (!cancellationToken.IsCancellationRequested)
                {
                    Thread.Sleep(Config.ScanReplyTimeout);
                    _tokenSource.Cancel();

                    foreach (var host in discoveredHosts)
                        host.HostName = NetworkUtilities.GetHostNameByIp(host.IpAddress);

                    OnScanFinished(new ScanFinishedEventArgs(discoveredHosts));
                }

                IsScanning = false;
            }, cancellationToken);
        }


        public void Cancel()
        {
            if (IsScanning && _tokenSource != null && !_tokenSource.IsCancellationRequested)
            {
                _totalScans = 0;
                _finishedScans = 0;
                _tokenSource.Cancel();
            }
        }
    }



    #region Event Args

    public class ScanFinishedEventArgs : EventArgs
    {
        public List<Host> Hosts { get; }


        public ScanFinishedEventArgs(List<Host> hosts)
        {
            this.Hosts = hosts;
        }
    }


    public class HostScannedEventArgs : EventArgs
    {
        public int Total { get; }
        public int Current { get; }


        public HostScannedEventArgs(int total, int current)
        {
            this.Total = total;
            this.Current = current;
        }
    }

    #endregion
}
