using PcapDotNet.Base;
using PcapDotNet.Packets.Ethernet;
using System;
using System.Collections.ObjectModel;

namespace EvilLimiter.Windows.Extensions
{
    public static class MacAddressExtensions
    {
        public static ReadOnlyCollection<byte> ToBytes(this MacAddress address)
        {
            var bytes = new byte[6];
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = Convert.ToByte(address.ToString().Split(':')[i], 16);

            return bytes.AsReadOnly();
        }
    }
}
