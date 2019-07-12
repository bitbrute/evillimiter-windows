using EvilLimiter.Windows.Common;
using EvilLimiter.Windows.Data;
using EvilLimiter.Windows.Utilities;
using MetroFramework;
using PcapDotNet.Core;
using PcapDotNet.Core.Extensions;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinDivertSharp;

namespace EvilLimiter.Windows.Forms
{
    public partial class FrmInterface : FrmBase
    {
        private readonly Dictionary<LivePacketDevice, DeviceAddress> _interfaces;
        private LivePacketDevice _currentInterface;
        private PacketCommunicator _packetCommunicator;



        public FrmInterface()
        {
            InitializeComponent();

            this._interfaces = new Dictionary<LivePacketDevice, DeviceAddress>();

            InitializeInterfaces();
        }



        private void InitializeInterfaces()
        {
            _interfaces.Clear();
            cbInterfaces.Items.Clear();

            foreach (var iface in LivePacketDevice.AllLocalMachine)
            {
                if (iface.Description != string.Empty)
                {
                    foreach (var address in iface.Addresses)
                    {
                        if (address.Address.Family == SocketAddressFamily.Internet)
                        {
                            _interfaces.Add(iface, address);
                            cbInterfaces.Items.Add(iface.GetNetworkInterface().Name);
                        }
                    }
                }
            }

            if (_interfaces.Count > 0)
                cbInterfaces.SelectedItem = cbInterfaces.Items[0];
            else
            {
                MetroMessageBox.Show(this, "No network interface detected.", "Interface Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
                Environment.Exit(-1);
            }
        }


        private void ShowStatus(string status)
        {
            lblStatus.Text = status;
            lblStatus.Visible = true;
            spinStatus.Visible = true;
        }


        private void HideStatus()
        {
            lblStatus.Visible = false;
            spinStatus.Visible = false;
        }


        private void UpdateAddresses(LivePacketDevice iface, DeviceAddress address)
        {
            var interfaceAddress = ((IpV4SocketAddress)address.Address).Address;
            lblInterfaceAddress.Text = interfaceAddress.ToString();

            if (address.Netmask?.Family == SocketAddressFamily.Internet)
                tbNetmask.Text = ((IpV4SocketAddress)address.Netmask).Address.ToString();

            var gateways = iface.GetNetworkInterface().GetIPProperties().GatewayAddresses;
            foreach (var gateway in gateways)
            {
                if (gateway.Address.AddressFamily == AddressFamily.InterNetwork)
                {
                    tbGatewayIp.Text = gateway.Address.ToString();

                    ShowStatus("resolving MAC address...");
                    cbInterfaces.Enabled = false;

                    Task.Run(() =>
                    {
                        var macAddress = NetworkUtilities.GetMacByIpAddress(iface, _packetCommunicator, interfaceAddress, new IpV4Address(gateway.Address.ToString()), 3000);
                        Invoke((MethodInvoker)delegate
                        {
                            if (macAddress != null)
                                tbGatewayMac.Text = macAddress.ToString();

                            HideStatus();
                            cbInterfaces.Enabled = true;
                        });
                    });
                }
            }
        }


        private NetworkInformation ParseNetworkInformation()
        {
            var errorMessage = new Action<string, string>((title, msg) => MetroMessageBox.Show(this, msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error, 120));

            IpV4Address gatewayIp;
            MacAddress gatewayMac;
            IpV4Address netmask;
            List<IpV4Address> subnetRange;
            IntPtr winDivertHandle;

            if (_currentInterface == null)
            {
                errorMessage("Interface Error", "No network interface selected.");
                return null;
            }

            try
            {
                gatewayIp = new IpV4Address(tbGatewayIp.Text);
            }
            catch (Exception)
            {
                errorMessage("Value Error", "Invalid gateway IP.");
                return null;
            }

            try
            {
                gatewayMac = new MacAddress(tbGatewayMac.Text);
            }
            catch (Exception)
            {
                errorMessage("Value Error", "Invalid gateway MAC.");
                return null;
            }

            try
            {
                netmask = new IpV4Address(tbNetmask.Text);
            }
            catch (Exception)
            {
                errorMessage("Value Error", "Invalid netmask.");
                return null;
            }

            try
            {
                subnetRange = NetworkUtilities.GetIpRange(string.Format("{0}/{1}", gatewayIp.ToString(), netmask.ToString()));
            }
            catch (Exception)
            {
                errorMessage("Value Error", "Invalid netmask.");
                return null;
            }

            winDivertHandle = WinDivert.WinDivertOpen("true", WinDivertLayer.Forward, 0, WinDivertOpenFlags.None);
            if (winDivertHandle == new IntPtr(-1))
            {
                errorMessage("WinDivert Error", string.Format("WinDivert handle could not be opened.\nError Code: {0}", Marshal.GetLastWin32Error()));
                return null;
            }

            return new NetworkInformation()
            {
                Interface = _currentInterface,
                Communicator = _packetCommunicator,
                InterfaceAddress = _interfaces[_currentInterface],
                GatewayIp = gatewayIp,
                GatewayMac = gatewayMac,
                Netmask = netmask,
                SubnetRange = subnetRange,
                WinDivertHandle = winDivertHandle,
            };
        }


        #region Form Events

        private void CbInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbGatewayIp.Clear();
            tbGatewayMac.Clear();
            tbNetmask.Clear();

            if (cbInterfaces.SelectedItem == null)
                return;

            if (_packetCommunicator != null)
            {
                _packetCommunicator.Dispose();
            }

            var iface = _interfaces.Keys.ElementAt(cbInterfaces.SelectedIndex);

            try
            {
                _packetCommunicator = iface.Open();
            }
            catch (Exception) { }
            
            if (_packetCommunicator == null)
            {
                MetroMessageBox.Show(this, "Network interface could not be opened.", "Interface Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 120);
                cbInterfaces.SelectedItem = null;
                _currentInterface = null;
                return;
            }

            _currentInterface = iface;
            UpdateAddresses(iface, _interfaces[iface]);
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
            var netInfo = ParseNetworkInformation();
            if (netInfo != null)
            {
                Hide();

                var frmMain = new FrmMain(netInfo);
                frmMain.FormClosed += new FormClosedEventHandler((s, args) => Close());
                frmMain.Show(this);
            }
        }

        #endregion
    }
}
