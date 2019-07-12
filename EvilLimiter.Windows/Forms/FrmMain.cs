using EvilLimiter.Windows.Common;
using EvilLimiter.Windows.Data;
using EvilLimiter.Windows.Networking;
using EvilLimiter.Windows.Utilities;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvilLimiter.Windows.Forms
{
    public partial class FrmMain : FrmBase
    {
        private enum HostColumn
        {
            IpAddress = 0,
            MacAddress = 1,
            HostName = 2,
            Upload = 3,
            Download = 4
        }



        private readonly NetworkInformation _networkInfo;
        private readonly FrmScan _frmScan;

        private readonly HostSpoofer _hostSpoofer;
        private readonly HostLimiter _hostLimiter;



        public FrmMain(NetworkInformation netInfo)
        {
            InitializeComponent();

            this._networkInfo = netInfo;

            this._frmScan = new FrmScan(_networkInfo);
            this._frmScan.ScanFinished += FrmScan_ScanFinished;

            this._hostSpoofer = new HostSpoofer(_networkInfo);
            this._hostSpoofer.Start();

            this._hostLimiter = new HostLimiter(_networkInfo);
            this._hostLimiter.BandwidthUpdated += HostLimiter_BandwidthUpdated;
            this._hostLimiter.Start();

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            InitializeForm();
            UpdateConfigDisplay();
        }



        private void InitializeForm()
        {
            lblVersion.Text = string.Format("v{0}", Globals.Version);

            cmbColorStyle.DataSource = Enum.GetValues(typeof(MetroColorStyle));
            cmbColorStyle.SelectedItem = Config.ColorStyle;

            tcHosts.SelectTab(0);
            tcSettings.SelectTab(0);
        }


        private void UpdateConfigDisplay()
        {
            tglRouting.Checked = Globals.RoutingService.Status == ServiceControllerStatus.Running;
            cbRoutingStartup.Checked = Config.StartRoutingServiceOnStartup;

            tbScanSendInterval.Text = Config.ScanSendInterval.ToString();
            tbScanReplyTimeout.Text = Config.ScanReplyTimeout.ToString();
            tbSpoofSendInterval.Text = Config.SpoofSendInterval.ToString();
            tbSpoofRestoreSendCount.Text = Config.SpoofRestoreSendCount.ToString();
            tbSpoofRestoreSendInterval.Text = Config.SpoofRestoreSendInterval.ToString();
            tbBandwidthMonitorUpdateInterval.Text = Config.BandwidthMonitorUpdateInterval.ToString();
        }


        private void UpdateHostListView(Host host)
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate { UpdateHostListView(host); });
            else
            {
                var item = lvwHosts.Items.Cast<ListViewItem>().Where(x => (Host)x.Tag == host).FirstOrDefault();
                if (item != null)
                {
                    item.SubItems[(int)HostColumn.IpAddress].Text = host.IpAddress.ToString();
                    item.SubItems[(int)HostColumn.MacAddress].Text = host.MacAddress.ToString();
                    item.SubItems[(int)HostColumn.HostName].Text = host.HostName;
                    item.SubItems[(int)HostColumn.Upload].Text = host.UploadStatus;
                    item.SubItems[(int)HostColumn.Download].Text = host.DownloadStatus;
                }
            }
        }


        private List<Host> GetAllHosts()
            => lvwHosts.Items.Cast<ListViewItem>().Select(x => (Host)x.Tag).ToList();


        private List<Host> GetSelectedHosts()
            => lvwHosts.SelectedItems.Cast<ListViewItem>().Select(x => (Host)x.Tag).ToList();


        private void AddHost(Host host)
        {
            if (GetAllHosts().Contains(host))
                return;

            var item = new ListViewItem(new string[Enum.GetNames(typeof(HostColumn)).Length])
            {
                Tag = host
            };

            lvwHosts.Items.Add(item);
            UpdateHostListView(host);
        }


        private void FreeHost(Host host)
        {
            _hostSpoofer.Remove(host);
            _hostLimiter.Remove(host);

            UpdateHostListView(host);
        }


        #region Subscribed Events

        private void FrmScan_ScanFinished(object sender, Networking.ScanFinishedEventArgs e)
        {
            foreach (var host in e.Hosts)
                AddHost(host);
        }

        private void HostLimiter_BandwidthUpdated(object sender, EventArgs e)
        {
            GetAllHosts()
                .Where(x => x.Status == Host.HostStatus.Limited)
                .ToList()
                .ForEach(UpdateHostListView);
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var msg = string.Format(
                @"
Type: {0}
Message: {1}

If this issue is unknown, please report it immediately on {2}.

The application will be terminated to avoid unwanted behaviour.",
                (e.ExceptionObject as Exception)?.GetType(),
                (e.ExceptionObject as Exception)?.Message,
                Globals.GithubRepoLink
            );

            MetroMessageBox.Show(
                this,
                msg,
                "Unhandled Exception",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                255
            );

            Environment.Exit(-1);
        }

        #endregion


        #region Form Events

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Config.StartRoutingServiceOnStartup)
                tglRouting.Checked = true;
        }

        private void BtnScan_Click(object sender, System.EventArgs e)
        {
            _frmScan.ShowDialog(this);
        }

        private void CmsHosts_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool moreThanZero = lvwHosts.SelectedItems.Count > 0;

            tsmiFree.Enabled = moreThanZero && GetSelectedHosts().Any(x => x.Status != Host.HostStatus.Free);
            tsmiRemove.Enabled = moreThanZero;
            tsmiLimit.Enabled = moreThanZero;
            tsmiBlock.Enabled = moreThanZero;
        }

        private void TsmiLimit_Click(object sender, System.EventArgs e)
        {
            var frmLimit = new FrmLimit(GetSelectedHosts());
            frmLimit.ShowDialog(this);

            if (frmLimit.Rule != null)
            {
                foreach (var host in frmLimit.Hosts)
                {
                    if (host.LimitRule != frmLimit.Rule)
                    {
                        _hostSpoofer.Add(host);
                        _hostLimiter.Add(host, frmLimit.Rule);

                        UpdateHostListView(host);
                    }
                }
            }
        }

        private void TsmiBlock_Click(object sender, EventArgs e)
        {
            foreach (var host in GetSelectedHosts())
            {
                _hostSpoofer.Add(host);
                _hostLimiter.Add(host, LimitRule.Block);

                UpdateHostListView(host);
            }
        }

        private void TsmiFree_Click(object sender, System.EventArgs e)
        {
            foreach (var host in GetSelectedHosts())
            {
                FreeHost(host);
                UpdateHostListView(host);
            }
        }

        private void TsmiAdd_Click(object sender, EventArgs e)
        {
            var frmAdd = new FrmAddHost(GetAllHosts());
            frmAdd.ShowDialog(this);

            if (frmAdd.Host != null)
                AddHost(frmAdd.Host);
        }

        private void TsmiRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwHosts.SelectedItems)
            {
                FreeHost((Host)item.Tag);
                lvwHosts.Items.Remove((ListViewItem)item);
            }
        }

        private void TsmiSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwHosts.Items)
                item.Selected = true;
        }

        private void TglRouting_CheckedChanged(object sender, EventArgs e)
        {
            var invokeGenerator = new Func<bool, MethodInvoker>(status => (MethodInvoker)delegate
            {
                tglRouting.Enabled = status;
                spinnerRouting.Visible = !status;
            });

            if (tglRouting.Checked && Globals.RoutingService.Status != ServiceControllerStatus.Running)
            {
                Task.Run(() =>
                {
                    Invoke(invokeGenerator(false));

                    ServiceUtilities.ChangeStartMode(Globals.RoutingService, ServiceStartMode.Manual);
                    Globals.RoutingService.Start();

                    while (Globals.RoutingService.Status != ServiceControllerStatus.Running)
                    {
                        Thread.Sleep(250);
                        Globals.RoutingService.Refresh();
                    }

                    Invoke(invokeGenerator(true));
                });
            }
            else if (!tglRouting.Checked && Globals.RoutingService.Status == ServiceControllerStatus.Running)
            {
                Task.Run(() =>
                {
                    Invoke(invokeGenerator(false));

                    Globals.RoutingService.Stop();
                    ServiceUtilities.ChangeStartMode(Globals.RoutingService, ServiceStartMode.Manual);

                    while (Globals.RoutingService.Status != ServiceControllerStatus.Stopped)
                    {
                        Thread.Sleep(250);
                        Globals.RoutingService.Refresh();
                    }

                    Invoke(invokeGenerator(true));
                });
            }
        }

        private void BtnApplySettings_Click(object sender, EventArgs e)
        {
            var errorMessage = new Action<string, string>((title, msg) => MetroMessageBox.Show(this, msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error, 120));
            var successMessage = new Action<string>((msg) => MetroMessageBox.Show(this, msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, 120));

            if (!int.TryParse(tbScanSendInterval.Text, out int scanSendInterval) || scanSendInterval < 0)
            {
                errorMessage("Value Error", "Invalid scan send interval.");
                return;
            }
            if (!int.TryParse(tbScanReplyTimeout.Text, out int scanReplyTimeout) || scanReplyTimeout < 0)
            {
                errorMessage("Value Error", "Invalid scan reply timeout.");
                return;
            }
            if (!int.TryParse(tbSpoofSendInterval.Text, out int spoofSendInterval) || spoofSendInterval < 0)
            {
                errorMessage("Value Error", "Invalid spoof send interval.");
                return;
            }
            if (!int.TryParse(tbSpoofRestoreSendCount.Text, out int spoofRestoreSendCount) || spoofRestoreSendCount < 0)
            {
                errorMessage("Value Error", "Invalid spoof restore send count.");
                return;
            }
            if (!int.TryParse(tbSpoofRestoreSendInterval.Text, out int spoofRestoreSendInterval) || spoofRestoreSendInterval < 0)
            {
                errorMessage("Value Error", "Invalid spoof restore send interval.");
                return;
            }
            if (!int.TryParse(tbBandwidthMonitorUpdateInterval.Text, out int bandwidthMonitorUpdateInterval) || bandwidthMonitorUpdateInterval <= 0)
            {
                errorMessage("Value Error", "Invalid bandwidth monitor update interval.");
                return;
            }
            if (!Enum.TryParse(cmbColorStyle.SelectedValue.ToString(), out MetroColorStyle colorStyle))
            {
                errorMessage("Value Error", "Invalid color style.");
                return;
            }

            if (Config.ColorStyle != colorStyle)
                FrmBase.OnColorStyleChanged(new ColorStyleChangedEventArgs(colorStyle));

            Config.StartRoutingServiceOnStartup = cbRoutingStartup.Checked;
            Config.ColorStyle = colorStyle;
            Config.ScanSendInterval = scanSendInterval;
            Config.ScanReplyTimeout = scanReplyTimeout;
            Config.SpoofSendInterval = spoofSendInterval;
            Config.SpoofRestoreSendCount = spoofRestoreSendCount;
            Config.SpoofRestoreSendInterval = spoofRestoreSendInterval;
            Config.BandwidthMonitorUpdateInterval = bandwidthMonitorUpdateInterval;

            if (Config.Write())
                successMessage("Changes have been applied.");
            else
                errorMessage("Write Error", "Could not write to config.");
        }

        private void LnkEvilLimiter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.github.com/bitbrute/evillimiter");
        }

        private void LnkGitHubPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Globals.GithubRepoLink);
        }

        private void LnkCredits_Click(object sender, EventArgs e)
        {
            var frmCredits = new FrmCredits();
            frmCredits.ShowDialog(this);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            if (GetAllHosts().Any(x => x.Status != Host.HostStatus.Free))
            {
                var result = MetroMessageBox.Show(
                    this,
                    "Currently limited hosts will not be freed gracefully.\nDo you still want to continue?",
                    "Are you sure?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, 120
                );

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }

        #endregion

    }
}
