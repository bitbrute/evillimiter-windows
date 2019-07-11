using System;

namespace EvilLimiter.Windows.Data
{
    public class LimitRule : IEquatable<LimitRule>
    {
        public static LimitRule Free => new LimitRule();
        public static LimitRule Block => new LimitRule() { UploadRate = 0, DownloadRate = 0 };


        public long? UploadRate { get; set; } = null;
        public long? UploadBurst { get; set; } = null;
        public long? DownloadRate { get; set; } = null;
        public long? DownloadBurst { get; set; } = null;

        public bool IsUploadLimited => UploadRate != null;
        public bool IsDownloadLimited => DownloadRate != null;
        public bool IsFree => !IsUploadLimited && !IsDownloadLimited;
        public bool IsUploadBlocked => UploadRate == 0;
        public bool IsDownloadBlocked => DownloadRate == 0;
        public bool IsBlocked => IsUploadBlocked && IsDownloadBlocked;



        #region Equality Comparison

        public bool Equals(LimitRule other)
        {
            if (other is null)
                return false;

            return UploadRate == other.UploadRate && UploadBurst == other.UploadBurst && DownloadRate == other.DownloadRate && DownloadBurst == other.DownloadBurst;
        }

        public override bool Equals(object obj)
            => Equals(obj as Host);

        public override int GetHashCode()
            => UploadRate.GetHashCode() ^ UploadBurst.GetHashCode() ^ DownloadRate.GetHashCode() ^ DownloadBurst.GetHashCode();

        public static bool operator == (LimitRule obj1, LimitRule obj2)
        {
            if (ReferenceEquals(obj1, null))
            {
                if (ReferenceEquals(obj2, null))
                    return true;
                return false;
            }

            return obj1.Equals(obj2);
        }

        public static bool operator !=(LimitRule obj1, LimitRule obj2)
            => !(obj1 == obj2);

        #endregion
    }
}
