using EvilLimiter.Windows.Data;
using EvilLimiter.Windows.Extensions;
using NetTools;
using PcapDotNet.Base;
using PcapDotNet.Core;
using PcapDotNet.Core.Extensions;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Arp;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace EvilLimiter.Windows.Utilities
{
    public static class NetworkUtilities
    {
        public static MacAddress BroadcastMac => new MacAddress("FF:FF:FF:FF:FF:FF");



        public static MacAddress PhysicalAddressToMacAddress(PhysicalAddress address)
            => new MacAddress(string.Join(":", address.GetAddressBytes().Select(x => x.ToString("X2")).ToArray()));


        public static List<IpV4Address> GetIpRange(string rangeString)
            => IPAddressRange.Parse(rangeString).AsEnumerable().Select(x => new IpV4Address(x.ToString())).ToList();


        public static MacAddress? GetMacByIpAddress(LivePacketDevice iface, PacketCommunicator communicator, IpV4Address sourceAddress, IpV4Address targetAddress, int timeout = 2000)
        {
            var sourcePhysicalAddress = iface.GetNetworkInterface().GetPhysicalAddress();

            MacAddress? result = null;
            var resultLock = new object();

            var tokenSource = new CancellationTokenSource();
            var cancellationToken = tokenSource.Token;

            var packet = PacketBuilder.Build(
                DateTime.Now,
                new EthernetLayer()
                {
                    EtherType = EthernetType.None,
                    Source = PhysicalAddressToMacAddress(sourcePhysicalAddress),
                    Destination = BroadcastMac,
                },
                new ArpLayer()
                {
                    ProtocolType = EthernetType.IpV4,
                    Operation = ArpOperation.Request,
                    SenderProtocolAddress = sourceAddress.ToBytes(),
                    SenderHardwareAddress = sourcePhysicalAddress.GetAddressBytes().AsReadOnly(),
                    TargetProtocolAddress = targetAddress.ToBytes(),
                    TargetHardwareAddress = MacAddress.Zero.ToBytes(),
                }
            );

            communicator.SendPacket(packet);

            Task.Run(() =>
            {
                while (true)
                {
                    if (cancellationToken.IsCancellationRequested)
                        break;

                    communicator.ReceivePacket(out Packet p);

                    if (p != null &&
                        p.IsValid &&
                        p.Ethernet.IsValid &&
                        p.Ethernet.EtherType == EthernetType.Arp &&
                        p.Ethernet.Arp.IsValid &&
                        p.Ethernet.Arp.Operation == ArpOperation.Reply &&
                        p.Ethernet.Arp.SenderProtocolIpV4Address == targetAddress &&
                        p.Ethernet.Arp.TargetProtocolIpV4Address == sourceAddress)
                    {
                        lock (resultLock)
                            result = new MacAddress(BitConverter.ToString(p.Ethernet.Arp.SenderHardwareAddress.ToArray()).Replace('-', ':'));

                        break;
                    }
                }
            });

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            while (true)
            {
                lock (resultLock)
                {
                    if (result != null)
                        return result;
                }

                if (stopwatch.ElapsedMilliseconds >= timeout)
                {
                    tokenSource.Cancel();
                    communicator.Break();
                    break;
                }
                else
                    Thread.Sleep(100);
            }

            return result;
        }


        public static string GetHostNameByIp(IpV4Address address)
        {
            try
            {
                return Dns.GetHostEntry(address.ToString())?.HostName;
            }
            catch (SocketException) { }

            return null;
        }


        public static double BreakDownBitRate(long rate, out BitByteUnit unit)
        {
            if (rate < 1024)
            {
                unit = BitByteUnit.Bit;
                return rate;
            }
            else if (rate < Math.Pow(1000, 2))
            {
                unit = BitByteUnit.KBit;
                return rate / 1000;
            }
            else if (rate < Math.Pow(1000, 3))
            {
                unit = BitByteUnit.MBit;
                return rate / Math.Pow(1000, 2);
            }
            else
            {
                unit = BitByteUnit.GBit;
                return rate / Math.Pow(1000, 3);
            }
        }


        public static long BrokenDownRateToBitRate(double rate, BitByteUnit unit)
        {
            switch (unit)
            {
                case BitByteUnit.Bit: return (long)rate;
                case BitByteUnit.Byte: return (long)(rate * 8);
                case BitByteUnit.KBit: return (long)(rate * 1000);
                case BitByteUnit.KByte: return (long)(rate * 1024 * 8);
                case BitByteUnit.MBit: return (long)(rate * Math.Pow(1000, 2));
                case BitByteUnit.MByte: return (long)(rate * Math.Pow(1024, 2) * 8);
                case BitByteUnit.GBit: return (long)(rate * Math.Pow(1000, 3));
                case BitByteUnit.GByte: return (long)(rate * Math.Pow(1024, 3) * 8);
                default:
                    throw new Exception("BitByteUnit missing");
            }
        }


        public static string FancyBitRate(long? rate, int dec = 1)
        {
            if (rate is null)
                return string.Empty;

            double num = BreakDownBitRate(rate.Value, out BitByteUnit unit);
            return string.Format("{0} {1}", num.ToString("N" + dec), unit);
        }


        public static long GetDefaultBurst(long rate)
            => rate / 10;
    }
}
