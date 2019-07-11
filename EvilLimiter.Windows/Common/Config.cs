using MetroFramework;
using System;
using System.Configuration;

namespace EvilLimiter.Windows.Common
{
    public static class Config
    {
        public static bool StartRoutingServiceOnStartup
        {
            get { lock (_startRoutingServiceOnStartupLock) return _startRoutingServiceOnStartup; }
            set { lock (_startRoutingServiceOnStartupLock) _startRoutingServiceOnStartup = value; }
        }


        public static MetroColorStyle ColorStyle
        {
            get { lock (_colorStyleLock) return _colorStyle; }
            set { lock (_colorStyleLock) _colorStyle = value; }
        }


        public static int ScanSendInterval
        {
            get { lock (_scanSendIntervalLock) return _scanSendInterval; }
            set { lock (_scanSendIntervalLock) _scanSendInterval = value; }
        }

        public static int ScanReplyTimeout
        {
            get { lock (_scanReplyTimeoutLock) return _scanReplyTimeout; }
            set { lock (_scanReplyTimeoutLock) _scanReplyTimeout = value; }
        }


        public static int SpoofSendInterval
        {
            get { lock (_spoofSendIntervalLock) return _spoofSendInterval; }
            set { lock (_spoofSendIntervalLock) _spoofSendInterval = value; }
        }

        public static int SpoofRestoreSendCount
        {
            get { lock (_spoofRestoreSendCountLock) return _spoofRestoreSendCount; }
            set { lock (_spoofRestoreSendCountLock) _spoofRestoreSendCount = value; }
        }

        public static int SpoofRestoreSendInterval
        {
            get { lock (_spoofRestoreSendIntervalLock) return _spoofRestoreSendInterval; }
            set { lock (_spoofRestoreSendIntervalLock) _spoofRestoreSendInterval = value; }
        }


        public static int BandwidthMonitorUpdateInterval
        {
            get { lock (_bandwidthMonitorUpdateIntervalLock) return _bandwidthMonitorUpdateInterval; }
            set { lock (_bandwidthMonitorUpdateIntervalLock) _bandwidthMonitorUpdateInterval = value; }
        }


        private static bool _startRoutingServiceOnStartup;
        private static readonly object _startRoutingServiceOnStartupLock;

        private static MetroColorStyle _colorStyle;
        private static readonly object _colorStyleLock;

        private static int _scanSendInterval;
        private static readonly object _scanSendIntervalLock;
        private static int _scanReplyTimeout;
        private static readonly object _scanReplyTimeoutLock;

        private static int _spoofSendInterval;
        private static readonly object _spoofSendIntervalLock;
        private static int _spoofRestoreSendCount;
        private static readonly object _spoofRestoreSendCountLock;
        private static int _spoofRestoreSendInterval;
        private static readonly object _spoofRestoreSendIntervalLock;

        private static int _bandwidthMonitorUpdateInterval;
        private static readonly object _bandwidthMonitorUpdateIntervalLock;



        static Config()
        {
            _startRoutingServiceOnStartup = false;
            _colorStyle = MetroColorStyle.Default;
            _scanSendInterval = 10;
            _scanReplyTimeout = 2000;
            _spoofSendInterval = 4000;
            _spoofRestoreSendCount = 3;
            _spoofRestoreSendInterval = 50;
            _bandwidthMonitorUpdateInterval = 1000;

            _startRoutingServiceOnStartupLock = new object();
            _colorStyleLock = new object();
            _scanSendIntervalLock = new object();
            _scanReplyTimeoutLock = new object();
            _spoofSendIntervalLock = new object();
            _spoofRestoreSendCountLock = new object();
            _spoofRestoreSendIntervalLock = new object();
            _bandwidthMonitorUpdateIntervalLock = new object();
        }



        public static bool Read()
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                StartRoutingServiceOnStartup = bool.Parse(config.AppSettings.Settings["StartRoutingServiceOnStartup"].Value);

                ColorStyle = (MetroColorStyle)Enum.Parse(typeof(MetroColorStyle), config.AppSettings.Settings["ColorStyle"].Value);

                ScanSendInterval = int.Parse(config.AppSettings.Settings["ScanSendInterval"].Value);
                ScanReplyTimeout = int.Parse(config.AppSettings.Settings["ScanReplyTimeout"].Value);

                SpoofSendInterval = int.Parse(config.AppSettings.Settings["SpoofSendInterval"].Value);
                SpoofRestoreSendCount = int.Parse(config.AppSettings.Settings["SpoofRestoreSendCount"].Value);
                SpoofRestoreSendInterval = int.Parse(config.AppSettings.Settings["SpoofRestoreSendInterval"].Value);

                BandwidthMonitorUpdateInterval = int.Parse(config.AppSettings.Settings["BandwidthMonitorUpdateInterval"].Value);

                return true;
            }
            catch (ConfigurationErrorsException)
            {
                return false;
            }
        }


        public static bool Write()
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings["StartRoutingServiceOnStartup"].Value = StartRoutingServiceOnStartup.ToString();

                config.AppSettings.Settings["ColorStyle"].Value = ColorStyle.ToString();

                config.AppSettings.Settings["ScanSendInterval"].Value = ScanSendInterval.ToString();
                config.AppSettings.Settings["ScanReplyTimeout"].Value = ScanReplyTimeout.ToString();

                config.AppSettings.Settings["SpoofSendInterval"].Value = SpoofSendInterval.ToString();
                config.AppSettings.Settings["SpoofRestoreSendCount"].Value = SpoofRestoreSendCount.ToString();
                config.AppSettings.Settings["SpoofRestoreSendInterval"].Value = SpoofRestoreSendInterval.ToString();

                config.AppSettings.Settings["BandwidthMonitorUpdateInterval"].Value = BandwidthMonitorUpdateInterval.ToString();

                config.Save();

                return true;
            }
            catch (ConfigurationErrorsException)
            {
                return false;
            }
        }
    }
}
