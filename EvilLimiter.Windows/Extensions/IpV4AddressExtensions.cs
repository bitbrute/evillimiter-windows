using PcapDotNet.Base;
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.ObjectModel;

namespace EvilLimiter.Windows.Extensions
{
    public static class IpV4AddressExtensions
    {
        public static ReadOnlyCollection<byte> ToBytes(this IpV4Address address)
        {
            var bytes = new byte[4];
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = Convert.ToByte(address.ToString().Split('.')[i], 10);

            return bytes.AsReadOnly();
        }
    }
}
