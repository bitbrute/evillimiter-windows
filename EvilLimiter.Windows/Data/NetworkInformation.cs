using PcapDotNet.Core;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.Generic;

namespace EvilLimiter.Windows.Data
{
    public class NetworkInformation
    {
        public LivePacketDevice Interface { get; set; }
        public PacketCommunicator Communicator { get; set; }
        public DeviceAddress InterfaceAddress { get; set; }

        public IpV4Address GatewayIp { get; set; }
        public MacAddress GatewayMac { get; set; }

        public IpV4Address Netmask { get; set; }

        public List<IpV4Address> SubnetRange { get; set; }
        public string SubnetRangeString => string.Format("{0}/{1}", GatewayIp.ToString(), Netmask.ToString());

        public IntPtr WinDivertHandle { get; set; }
    }
}
