using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilLimiter.Windows.Data
{
    public class HostConnectionInformation
    {
        public long? UploadBitsPerSecond
        {
            get { lock (_uploadBitsPerSecondLock) return _uploadBitsPerSecond; }
            set { lock (_uploadBitsPerSecondLock) _uploadBitsPerSecond = value; }
        }

        public long? DownloadBitsPerSecond
        {
            get { lock (_downloadBitsPerSecondLock) return _downloadBitsPerSecond; }
            set { lock (_downloadBitsPerSecondLock) _downloadBitsPerSecond = value; }
        }


        private long? _uploadBitsPerSecond;
        private readonly object _uploadBitsPerSecondLock = new object();
        private long? _downloadBitsPerSecond;
        private readonly object _downloadBitsPerSecondLock = new object();



        public void Reset()
        {
            UploadBitsPerSecond = null;
            DownloadBitsPerSecond = null;
        }
    }
}
