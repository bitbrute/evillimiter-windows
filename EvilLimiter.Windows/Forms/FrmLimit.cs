using EvilLimiter.Windows.Data;
using EvilLimiter.Windows.Utilities;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EvilLimiter.Windows.Forms
{
    public partial class FrmLimit : FrmBase
    {
        public IEnumerable<Host> Hosts { get; }
        public LimitRule Rule { get; private set; }



        public FrmLimit(IEnumerable<Host> hosts)
        {
            InitializeComponent();

            this.Hosts = hosts;

            Initialize();
        }



        private void Initialize()
        {
            new List<ComboBox>() { cmbUploadRate, cmbUploadBurst, cmbDownloadRate, cmbDownloadBurst }.ForEach(x => x.DataSource = Enum.GetValues(typeof(BitByteUnit)));
            cmbUploadRate.SelectedItem = cmbUploadBurst.SelectedItem = cmbDownloadRate.SelectedItem = cmbDownloadBurst.SelectedItem = BitByteUnit.KBit;

            if (Hosts.All(x => x.Status != Host.HostStatus.Free))
            {
                if (Hosts.All(x => x.LimitRule.IsUploadLimited))
                {
                    tglUpload.Checked = true;

                    if (Hosts.All(x => Hosts.First().LimitRule.UploadRate == x.LimitRule.UploadRate))
                    {
                        var rate = NetworkUtilities.BreakDownBitRate(Hosts.First().LimitRule.UploadRate.Value, out BitByteUnit unit);

                        tbUploadRate.Text = rate.ToString();
                        cmbUploadRate.SelectedItem = unit;
                    }

                    if (Hosts.First().LimitRule.UploadBurst != null && Hosts.All(x => Hosts.First().LimitRule.UploadBurst == x.LimitRule.UploadBurst))
                    {
                        var burst = NetworkUtilities.BreakDownBitRate(Hosts.First().LimitRule.UploadBurst.Value, out BitByteUnit unit);

                        tbUploadBurst.Text = burst.ToString();
                        cmbUploadBurst.SelectedItem = unit;
                        cbUploadBurst.Checked = true;
                    }
                }

                if (Hosts.All(x => x.LimitRule.IsDownloadLimited))
                {
                    tglDownload.Checked = true;

                    if (Hosts.All(x => Hosts.First().LimitRule.DownloadRate == x.LimitRule.DownloadRate))
                    {
                        var rate = NetworkUtilities.BreakDownBitRate(Hosts.First().LimitRule.DownloadRate.Value, out BitByteUnit unit);

                        tbDownloadRate.Text = rate.ToString();
                        cmbDownloadRate.SelectedItem = unit;
                    }

                    if (Hosts.First().LimitRule.DownloadBurst != null && Hosts.All(x => Hosts.First().LimitRule.DownloadBurst == x.LimitRule.DownloadBurst))
                    {
                        var burst = NetworkUtilities.BreakDownBitRate(Hosts.First().LimitRule.DownloadBurst.Value, out BitByteUnit unit);

                        tbDownloadBurst.Text = burst.ToString();
                        cmbDownloadBurst.SelectedItem = unit;
                        cbDownloadBurst.Checked = true;
                    }
                }
            }
        }


        private LimitRule ParseLimitInformation()
        {
            var errorMessage = new Action<string, string>((title, msg) => MetroMessageBox.Show(this, msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error, 120));
            var rule = LimitRule.Free;

            if (tglUpload.Checked)
            {
                if (!double.TryParse(tbUploadRate.Text, out double rate))
                {
                    errorMessage("Value Error", "Invalid upload rate.");
                    return null;
                }

                rule.UploadRate = NetworkUtilities.BrokenDownRateToBitRate(rate, (BitByteUnit)Enum.Parse(typeof(BitByteUnit), cmbUploadRate.SelectedItem.ToString()));

                if (cbUploadBurst.Checked)
                {
                    if (!double.TryParse(tbUploadBurst.Text, out double burst))
                    {
                        errorMessage("Value Error", "Invalid upload burst.");
                        return null;
                    }

                    rule.UploadBurst = NetworkUtilities.BrokenDownRateToBitRate(burst, (BitByteUnit)Enum.Parse(typeof(BitByteUnit), cmbUploadBurst.SelectedItem.ToString()));
                }
            }

            if (tglDownload.Checked)
            {
                if (!double.TryParse(tbDownloadRate.Text, out double rate))
                {
                    errorMessage("Value Error", "Invalid download rate.");
                    return null;
                }

                rule.DownloadRate = NetworkUtilities.BrokenDownRateToBitRate(rate, (BitByteUnit)Enum.Parse(typeof(BitByteUnit), cmbDownloadRate.SelectedItem.ToString()));

                if (cbDownloadBurst.Checked)
                {
                    if (!double.TryParse(tbDownloadBurst.Text, out double burst))
                    {
                        errorMessage("Value Error", "Invalid download burst.");
                        return null;
                    }

                    rule.DownloadBurst = NetworkUtilities.BrokenDownRateToBitRate(burst, (BitByteUnit)Enum.Parse(typeof(BitByteUnit), cmbDownloadBurst.SelectedItem.ToString()));
                }
            }

            return rule;
        }


        #region Form Events

        private void TglUpload_CheckedChanged(object sender, EventArgs e)
        {
            pnlUpload.Enabled = tglUpload.Checked;
        }

        private void TglDownload_CheckedChanged(object sender, EventArgs e)
        {
            pnlDownload.Enabled = tglDownload.Checked;
        }

        private void CbUploadBurst_CheckedChanged(object sender, EventArgs e)
        {
            tbUploadBurst.Enabled = cmbUploadBurst.Enabled = cbUploadBurst.Checked;
        }

        private void CbDownloadBurst_CheckedChanged(object sender, EventArgs e)
        {
            tbDownloadBurst.Enabled = cmbDownloadBurst.Enabled = cbDownloadBurst.Checked;
        }

        private void BtnLimit_Click(object sender, EventArgs e)
        {
            var rule = ParseLimitInformation();
            if (rule != null)
            {
                Rule = rule;
                Close();
            }
        }

        #endregion
    }
}
