using EvilLimiter.Windows.Utilities;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using System;

namespace EvilLimiter.Windows.Data
{
    public class Host : IEquatable<Host>
    {
        public enum HostStatus
        {
            Free,
            Limited
        }



        public IpV4Address IpAddress { get; }
        public MacAddress MacAddress { get; }
        public string HostName { get; set; }


        public LimitRule LimitRule { get; private set; } = LimitRule.Free;
        public HostConnectionInformation ConnectionInfo { get; } = new HostConnectionInformation();
        public HostStatus Status
        {
            get
            {
                if (LimitRule.IsFree)
                    return HostStatus.Free;
                else
                    return HostStatus.Limited;
            }
        }

        public string UploadStatus
        {
            get
            {
                if (Status == HostStatus.Free || !LimitRule.IsUploadLimited)
                    return string.Empty;

                return string.Format(
                    "{0} / {1}",
                    NetworkUtilities.FancyBitRate(ConnectionInfo.UploadBitsPerSecond, 1),
                    NetworkUtilities.FancyBitRate(LimitRule.UploadRate, 1)
                );
            }
        }

        public string DownloadStatus
        {
            get
            {
                if (Status == HostStatus.Free || !LimitRule.IsDownloadLimited)
                    return string.Empty;

                return string.Format(
                    "{0} / {1}",
                    NetworkUtilities.FancyBitRate(ConnectionInfo.DownloadBitsPerSecond, 1),
                    NetworkUtilities.FancyBitRate(LimitRule.DownloadRate, 1)
                );
            }
        }



        public Host(IpV4Address ip, MacAddress mac)
        {
            this.IpAddress = ip;
            this.MacAddress = mac;
        }



        #region Equality Comparison

        public bool Equals(Host other)
        {
            if (other is null)
                return false; ;

            return IpAddress == other.IpAddress && MacAddress == other.MacAddress;
        }

        public override bool Equals(object obj)
            => Equals(obj as Host);

        public override int GetHashCode()
            => IpAddress.GetHashCode() ^ MacAddress.GetHashCode();

        public static bool operator ==(Host obj1, Host obj2)
        {
            if (ReferenceEquals(obj1, null))
            {
                if (ReferenceEquals(obj2, null))
                    return true;
                return false;
            }

            return obj1.Equals(obj2);
        }

        public static bool operator !=(Host obj1, Host obj2)
            => !(obj1 == obj2);

        #endregion


        public void SetLimitRule(LimitRule rule)
        {
            LimitRule = rule;
            if (rule == LimitRule.Free)
                ConnectionInfo.Reset();
        }
    }
}
