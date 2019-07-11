using Esendex.TokenBucket;
using EvilLimiter.Windows.Common;
using EvilLimiter.Windows.Data;
using EvilLimiter.Windows.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using WinDivertSharp;

namespace EvilLimiter.Windows.Networking
{
    public class HostLimiter
    {
        public bool IsLimiting { get; private set; }

        #region Events

        public event EventHandler BandwidthUpdated;
        private void OnBandwidthUpdated()
            => BandwidthUpdated?.Invoke(this, EventArgs.Empty);

        #endregion


        private readonly NetworkInformation _networkInfo;
        private readonly Dictionary<Host, Tuple<ITokenBucket, ITokenBucket>> _hostBucketDict;
        private readonly object _hostBucketDictLock;
        private readonly Dictionary<IPAddress, Host> _ipHostDict;
        private readonly object _ipHostDictLock;

        private readonly Dictionary<Host, long> _bandwidthUploadDict;
        private readonly object _bandwidthUploadDictLock;
        private readonly Dictionary<Host, long> _bandwidthDownloadDict;
        private readonly object _bandwidthDownloadDictLock;

        private readonly System.Windows.Forms.Timer _timer;
        private CancellationTokenSource _tokenSource;



        public HostLimiter(NetworkInformation netInfo)
        {
            this._networkInfo = netInfo;
            this._hostBucketDict = new Dictionary<Host, Tuple<ITokenBucket, ITokenBucket>>();
            this._hostBucketDictLock = new object();
            this._ipHostDict = new Dictionary<IPAddress, Host>();
            this._ipHostDictLock = new object();

            this._bandwidthUploadDict = new Dictionary<Host, long>();
            this._bandwidthUploadDictLock = new object();
            this._bandwidthDownloadDict = new Dictionary<Host, long>();
            this._bandwidthDownloadDictLock = new object();

            this._timer = new System.Windows.Forms.Timer();
            this._timer.Tick += Timer_Tick;
        }



        public void Start()
        {
            if (IsLimiting)
                return;

            _tokenSource = new CancellationTokenSource();
            var token = _tokenSource.Token;

            _timer.Interval = Config.BandwidthMonitorUpdateInterval;
            _timer.Start();

            Task.Run(() => LimitLoop(token), token);
            IsLimiting = true;
        }


        public void Stop()
        {
            if (!IsLimiting)
                return;

            _tokenSource.Cancel();
            _timer.Stop();

            IsLimiting = false;
        }


        public void Add(Host host, LimitRule rule)
        {
            ITokenBucket ulBucket = null;
            ITokenBucket dlBucket = null;

            Remove(host);
            host.SetLimitRule(rule);

            if (rule.IsUploadLimited && !rule.IsUploadBlocked)
                ulBucket = TokenBuckets.Construct()
                    .WithCapacity(rule.UploadRate.Value + (rule.UploadBurst ?? NetworkUtilities.GetDefaultBurst(rule.UploadRate.Value)))
                    .WithFixedIntervalRefillStrategy(rule.UploadRate.Value, TimeSpan.FromSeconds(1))
                    .Build();

            if (rule.IsDownloadLimited && !rule.IsDownloadBlocked)
                dlBucket = TokenBuckets.Construct()
                    .WithCapacity(rule.DownloadRate.Value + (rule.DownloadBurst ?? NetworkUtilities.GetDefaultBurst(rule.DownloadRate.Value)))
                    .WithFixedIntervalRefillStrategy(rule.DownloadRate.Value, TimeSpan.FromSeconds(1))
                    .Build();

            if (ulBucket == null && dlBucket == null && !host.LimitRule.IsUploadBlocked && !host.LimitRule.IsDownloadBlocked)
                return;

            var buckets = new Tuple<ITokenBucket, ITokenBucket>(ulBucket, dlBucket);

            lock (_hostBucketDictLock) lock (_ipHostDict) lock (_bandwidthUploadDictLock) lock (_bandwidthDownloadDictLock)
            {
                _hostBucketDict.Add(host, buckets);
                _ipHostDict.Add(IPAddress.Parse(host.IpAddress.ToString()), host);
                _bandwidthUploadDict.Add(host, 0);
                _bandwidthDownloadDict.Add(host, 0);
            }
        }


        public void Remove(Host host)
        {
            lock (_hostBucketDictLock) lock (_ipHostDict) lock (_bandwidthUploadDictLock) lock (_bandwidthDownloadDictLock)
            {
                if (_hostBucketDict.ContainsKey(host))
                {
                    _hostBucketDict.Remove(host);
                    _ipHostDict.Remove(IPAddress.Parse(host.IpAddress.ToString()));
                    _bandwidthUploadDict.Remove(host);
                    _bandwidthDownloadDict.Remove(host);

                    host.SetLimitRule(LimitRule.Free);
                }
            }
        }


        private unsafe void LimitLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var buffer = new WinDivertBuffer();
                var address = new WinDivertAddress();
                uint readLength = 0;

                bool recvResult = WinDivert.WinDivertRecv(_networkInfo.WinDivertHandle, buffer, ref address, ref readLength);
                if (!recvResult)
                    throw new Exception("WinDivert failed to receive packet");
                
                var parseResult = WinDivert.WinDivertHelperParsePacket(buffer, readLength);
                Host host = null;
                ITokenBucket bucket = null;
                WinDivertDirection? direction = null;

                if (parseResult.IPv4Header != (IPv4Header*)0)
                {
                    lock (_ipHostDictLock) lock (_hostBucketDictLock)
                    {
                        if (_ipHostDict.TryGetValue(parseResult.IPv4Header->SrcAddr, out host))
                        {
                            bucket = _hostBucketDict[host].Item1;
                            direction = WinDivertDirection.Outbound;
                        }
                        else if (_ipHostDict.TryGetValue(parseResult.IPv4Header->DstAddr, out host))
                        {
                            bucket = _hostBucketDict[host].Item2;
                            direction = WinDivertDirection.Inbound;
                        }
                    }

                    if (host != null &&
                        (host.LimitRule.IsBlocked ||
                         (direction == WinDivertDirection.Outbound && host.LimitRule.IsUploadBlocked) ||
                         (direction == WinDivertDirection.Inbound && host.LimitRule.IsDownloadBlocked)))
                    {
                        buffer.Dispose();
                        continue;
                    }

                    if (bucket != null)
                    {
                        bool passed = false;

                        try
                        {
                            passed = bucket.TryConsume(readLength * 8);
                        }
                        catch (ArgumentOutOfRangeException) { }

                        if (passed)
                        {
                            switch (direction)
                            {
                            case WinDivertDirection.Outbound:
                                lock (_bandwidthUploadDictLock)
                                    _bandwidthUploadDict[host] += readLength * 8;
                                break;
                            case WinDivertDirection.Inbound:
                                lock (_bandwidthDownloadDictLock)
                                    _bandwidthDownloadDict[host] += readLength * 8;
                                break;
                            }
                        }
                        else
                        {
                            buffer.Dispose();
                            continue;
                        }
                    }
                }

                WinDivert.WinDivertSend(_networkInfo.WinDivertHandle, buffer, readLength, ref address);
                buffer.Dispose();
            }
        }


        #region Subscribed Events

        private void Timer_Tick(object sender, EventArgs e)
        {
            lock (_bandwidthUploadDictLock)
            {
                foreach (var host in _bandwidthUploadDict.Keys.ToList())
                {
                    host.ConnectionInfo.UploadBitsPerSecond = (long)(_bandwidthUploadDict[host] * (1000f / Config.BandwidthMonitorUpdateInterval));
                    _bandwidthUploadDict[host] = 0;
                }
            }

            lock (_bandwidthDownloadDictLock)
            {
                foreach (var host in _bandwidthDownloadDict.Keys.ToList())
                {
                    host.ConnectionInfo.DownloadBitsPerSecond = (long)(_bandwidthDownloadDict[host] * (1000f / Config.BandwidthMonitorUpdateInterval));
                    _bandwidthDownloadDict[host] = 0;
                }
            }

            _timer.Stop();
            _timer.Interval = Config.BandwidthMonitorUpdateInterval;
            _timer.Start();

            OnBandwidthUpdated();
        }

        #endregion
    }
}
