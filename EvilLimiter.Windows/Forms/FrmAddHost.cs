using EvilLimiter.Windows.Data;
using MetroFramework;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EvilLimiter.Windows.Forms
{
    public partial class FrmAddHost : FrmBase
    {
        public Host Host { get; private set; }

        private readonly ICollection<Host> _hosts;



        public FrmAddHost(ICollection<Host> hosts)
        {
            InitializeComponent();

            this._hosts = hosts;
        }



        private Host ParseHostInformation()
        {
            var errorMessage = new Action<string, string>((title, msg) => MetroMessageBox.Show(this, msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error, 120));

            IpV4Address ip;
            MacAddress mac;

            try
            {
                ip = new IpV4Address(tbIpAddress.Text);
            }
            catch (Exception)
            {
                errorMessage("Value Error", "Invalid IP address.");
                return null;
            }

            try
            {
                mac = new MacAddress(tbMacAddress.Text);
            }
            catch (Exception)
            {
                errorMessage("Value Error", "Invalid MAC address");
                return null;
            }

            var host = new Host(ip, mac) { HostName = tbHostName.Text };

            if (_hosts.Contains(host))
            {
                errorMessage("Duplicate", "Specified host does already exist.");
                return null;
            }
            else
                return host;
        }


        #region Form Events

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            Host = ParseHostInformation();
            if (Host != null)
                Close();
        }

        #endregion
    }
}
