using EvilLimiter.Windows.Data;
using EvilLimiter.Windows.Networking;
using EvilLimiter.Windows.Utilities;
using MetroFramework;
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EvilLimiter.Windows.Forms
{
    public partial class FrmScan : FrmBase
    {
        private enum ScanState
        {
            Scan,
            Cancel,
            Finish
        }



        private readonly NetworkInformation _networkInfo;
        private readonly HostScanner _hostScanner;


        #region Events

        public event EventHandler<ScanFinishedEventArgs> ScanFinished;
        private void OnScanFinished(ScanFinishedEventArgs e)
            => ScanFinished?.Invoke(this, e);

        #endregion



        public FrmScan(NetworkInformation netInfo)
        {
            InitializeComponent();

            this._networkInfo = netInfo;

            this._hostScanner = new HostScanner(netInfo);
            this._hostScanner.HostScanned += HostScanner_HostScanned;
            this._hostScanner.ScanFinished += HostScanner_ScanFinished;

            InitializeData();
        }



        private void InitializeData()
        {
            lblSubnetRange.Text = _networkInfo.SubnetRangeString;
        }



        private void ChangeScanState(ScanState state)
        {
            switch (state)
            {
                case ScanState.Scan:
                    btnScan.Text = "Cancel";
                    lblStatus.Text = "Scanning...";
                    break;
                case ScanState.Cancel:
                    btnScan.Text = "Scan";
                    lblStatus.Text = "Cancelled";
                    pbScan.Value = 0;
                    break;
                case ScanState.Finish:
                    btnScan.Text = "Scan";
                    lblStatus.Text = "Finished";
                    pbScan.Value = 0;
                    btnScan.Enabled = true;
                    break;
            }
        }


        #region Subscribed Events

        private void HostScanner_ScanFinished(object sender, ScanFinishedEventArgs e)
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate { HostScanner_ScanFinished(sender, e); });
            else
            {
                ChangeScanState(ScanState.Finish);
                OnScanFinished(e);
            }
        }

        private void HostScanner_HostScanned(object sender, HostScannedEventArgs e)
        {
            if (!_hostScanner.IsScanning)
                return;

            if (InvokeRequired)
                Invoke((MethodInvoker)delegate { HostScanner_HostScanned(sender, e); });
            else
            {
                pbScan.Maximum = e.Total;
                pbScan.Value = e.Current;

                if (e.Current == e.Total)
                {
                    btnScan.Enabled = false;
                    lblStatus.Text = "Resolving hostnames...";
                }
            }
        }

        #endregion


        #region Form Events

        private void BtnScan_Click(object sender, System.EventArgs e)
        {
            if (_hostScanner.IsScanning)
            {
                _hostScanner.Cancel();
                ChangeScanState(ScanState.Cancel);
            }
            else
            {
                List<IpV4Address> range;

                if (rbtnCustomRange.Checked)
                {
                    try
                    {
                        range = NetworkUtilities.GetIpRange(tbIpRange.Text);
                    }
                    catch (FormatException)
                    {
                        MetroMessageBox.Show(this, "IP range string is invalid.", "Scan Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
                        return;
                    }
                }
                else
                    range = _networkInfo.SubnetRange;

                ChangeScanState(ScanState.Scan);
                _hostScanner.Scan(range);
            }
        }

        private void FrmScan_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            if (_hostScanner.IsScanning)
                MetroMessageBox.Show(this, "Cancel the scan or wait till it is finished to close the window.", "Cancel Scan", MessageBoxButtons.OK, MessageBoxIcon.Warning, 130);
            else
                Hide();

            e.Cancel = true;
        }

        #endregion
    }
}
