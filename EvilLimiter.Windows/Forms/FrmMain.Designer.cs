namespace EvilLimiter.Windows.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmsHosts = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tsmiLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFree = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnScan = new MetroFramework.Controls.MetroButton();
            this.lblVersion = new MetroFramework.Controls.MetroLabel();
            this.lvwHosts = new EvilLimiter.Windows.Controls.ListViewNF();
            this.chIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUpload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDownload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcHosts = new MetroFramework.Controls.MetroTabControl();
            this.tpHosts = new MetroFramework.Controls.MetroTabPage();
            this.tpSettings = new MetroFramework.Controls.MetroTabPage();
            this.btnApplySettings = new MetroFramework.Controls.MetroButton();
            this.tcSettings = new MetroFramework.Controls.MetroTabControl();
            this.tpRoutingSettings = new MetroFramework.Controls.MetroTabPage();
            this.cbRoutingStartup = new MetroFramework.Controls.MetroCheckBox();
            this.spinnerRouting = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.tglRouting = new MetroFramework.Controls.MetroToggle();
            this.tpScanSettings = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbScanReplyTimeout = new MetroFramework.Controls.MetroTextBox();
            this.tbScanSendInterval = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tpSpoofSettings = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tbSpoofRestoreSendInterval = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tbSpoofRestoreSendCount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tbSpoofSendInterval = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tpAppearanceSettings = new MetroFramework.Controls.MetroTabPage();
            this.cmbColorStyle = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tpOtherSettings = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbBandwidthMonitorUpdateInterval = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tpAbout = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.lnkCredits = new MetroFramework.Controls.MetroLink();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lnkGitHubPage = new MetroFramework.Controls.MetroLink();
            this.lnkEvilLimiter = new MetroFramework.Controls.MetroLink();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.cmsHosts.SuspendLayout();
            this.tcHosts.SuspendLayout();
            this.tpHosts.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tpRoutingSettings.SuspendLayout();
            this.tpScanSettings.SuspendLayout();
            this.tpSpoofSettings.SuspendLayout();
            this.tpAppearanceSettings.SuspendLayout();
            this.tpOtherSettings.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsHosts
            // 
            this.cmsHosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmsHosts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmsHosts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLimit,
            this.tsmiBlock,
            this.tsmiFree,
            this.toolStripMenuItem1,
            this.tsmiAdd,
            this.tsmiRemove,
            this.toolStripMenuItem2,
            this.tsmiSelectAll});
            this.cmsHosts.Name = "cmsHosts";
            this.cmsHosts.Size = new System.Drawing.Size(123, 148);
            this.cmsHosts.Opening += new System.ComponentModel.CancelEventHandler(this.CmsHosts_Opening);
            // 
            // tsmiLimit
            // 
            this.tsmiLimit.Name = "tsmiLimit";
            this.tsmiLimit.Size = new System.Drawing.Size(122, 22);
            this.tsmiLimit.Text = "Limit...";
            this.tsmiLimit.Click += new System.EventHandler(this.TsmiLimit_Click);
            // 
            // tsmiBlock
            // 
            this.tsmiBlock.Name = "tsmiBlock";
            this.tsmiBlock.Size = new System.Drawing.Size(122, 22);
            this.tsmiBlock.Text = "Block";
            this.tsmiBlock.Click += new System.EventHandler(this.TsmiBlock_Click);
            // 
            // tsmiFree
            // 
            this.tsmiFree.Name = "tsmiFree";
            this.tsmiFree.Size = new System.Drawing.Size(122, 22);
            this.tsmiFree.Text = "Free";
            this.tsmiFree.Click += new System.EventHandler(this.TsmiFree_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(122, 22);
            this.tsmiAdd.Text = "Add...";
            this.tsmiAdd.Click += new System.EventHandler(this.TsmiAdd_Click);
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(122, 22);
            this.tsmiRemove.Text = "Remove";
            this.tsmiRemove.Click += new System.EventHandler(this.TsmiRemove_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(122, 22);
            this.tsmiSelectAll.Text = "Select All";
            this.tsmiSelectAll.Click += new System.EventHandler(this.TsmiSelectAll_Click);
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Highlight = true;
            this.btnScan.Location = new System.Drawing.Point(572, 308);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(135, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan...";
            this.btnScan.UseSelectable = true;
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblVersion.Location = new System.Drawing.Point(272, 34);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(34, 15);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "v1.0.0";
            // 
            // lvwHosts
            // 
            this.lvwHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwHosts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIp,
            this.chMac,
            this.chHostName,
            this.chUpload,
            this.chDownload});
            this.lvwHosts.ContextMenuStrip = this.cmsHosts;
            this.lvwHosts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvwHosts.FullRowSelect = true;
            this.lvwHosts.Location = new System.Drawing.Point(0, 13);
            this.lvwHosts.Name = "lvwHosts";
            this.lvwHosts.OwnerDraw = true;
            this.lvwHosts.Scrollable = false;
            this.lvwHosts.Size = new System.Drawing.Size(710, 289);
            this.lvwHosts.TabIndex = 3;
            this.lvwHosts.UseCompatibleStateImageBehavior = false;
            this.lvwHosts.UseSelectable = true;
            this.lvwHosts.View = System.Windows.Forms.View.Details;
            // 
            // chIp
            // 
            this.chIp.Text = "IP address";
            this.chIp.Width = 128;
            // 
            // chMac
            // 
            this.chMac.Text = "MAC address";
            this.chMac.Width = 143;
            // 
            // chHostName
            // 
            this.chHostName.Text = "Hostname";
            this.chHostName.Width = 189;
            // 
            // chUpload
            // 
            this.chUpload.Text = "Upload";
            this.chUpload.Width = 124;
            // 
            // chDownload
            // 
            this.chDownload.Text = "Download";
            this.chDownload.Width = 124;
            // 
            // tcHosts
            // 
            this.tcHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcHosts.Controls.Add(this.tpHosts);
            this.tcHosts.Controls.Add(this.tpSettings);
            this.tcHosts.Controls.Add(this.tpAbout);
            this.tcHosts.Location = new System.Drawing.Point(23, 79);
            this.tcHosts.Name = "tcHosts";
            this.tcHosts.SelectedIndex = 0;
            this.tcHosts.Size = new System.Drawing.Size(718, 376);
            this.tcHosts.TabIndex = 4;
            this.tcHosts.UseSelectable = true;
            // 
            // tpHosts
            // 
            this.tpHosts.Controls.Add(this.lvwHosts);
            this.tpHosts.Controls.Add(this.btnScan);
            this.tpHosts.HorizontalScrollbarBarColor = true;
            this.tpHosts.HorizontalScrollbarHighlightOnWheel = false;
            this.tpHosts.HorizontalScrollbarSize = 10;
            this.tpHosts.Location = new System.Drawing.Point(4, 38);
            this.tpHosts.Name = "tpHosts";
            this.tpHosts.Size = new System.Drawing.Size(710, 334);
            this.tpHosts.TabIndex = 0;
            this.tpHosts.Text = "Hosts";
            this.tpHosts.VerticalScrollbarBarColor = true;
            this.tpHosts.VerticalScrollbarHighlightOnWheel = false;
            this.tpHosts.VerticalScrollbarSize = 10;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.btnApplySettings);
            this.tpSettings.Controls.Add(this.tcSettings);
            this.tpSettings.HorizontalScrollbarBarColor = true;
            this.tpSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSettings.HorizontalScrollbarSize = 10;
            this.tpSettings.Location = new System.Drawing.Point(4, 38);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(710, 334);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.VerticalScrollbarBarColor = true;
            this.tpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tpSettings.VerticalScrollbarSize = 10;
            // 
            // btnApplySettings
            // 
            this.btnApplySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplySettings.Highlight = true;
            this.btnApplySettings.Location = new System.Drawing.Point(572, 308);
            this.btnApplySettings.Name = "btnApplySettings";
            this.btnApplySettings.Size = new System.Drawing.Size(135, 23);
            this.btnApplySettings.TabIndex = 13;
            this.btnApplySettings.Text = "Apply";
            this.btnApplySettings.UseSelectable = true;
            this.btnApplySettings.Click += new System.EventHandler(this.BtnApplySettings_Click);
            // 
            // tcSettings
            // 
            this.tcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSettings.Controls.Add(this.tpRoutingSettings);
            this.tcSettings.Controls.Add(this.tpScanSettings);
            this.tcSettings.Controls.Add(this.tpSpoofSettings);
            this.tcSettings.Controls.Add(this.tpAppearanceSettings);
            this.tcSettings.Controls.Add(this.tpOtherSettings);
            this.tcSettings.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tcSettings.Location = new System.Drawing.Point(0, 13);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 4;
            this.tcSettings.Size = new System.Drawing.Size(710, 289);
            this.tcSettings.TabIndex = 2;
            this.tcSettings.UseSelectable = true;
            // 
            // tpRoutingSettings
            // 
            this.tpRoutingSettings.Controls.Add(this.cbRoutingStartup);
            this.tpRoutingSettings.Controls.Add(this.spinnerRouting);
            this.tpRoutingSettings.Controls.Add(this.metroLabel11);
            this.tpRoutingSettings.Controls.Add(this.tglRouting);
            this.tpRoutingSettings.HorizontalScrollbarBarColor = true;
            this.tpRoutingSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tpRoutingSettings.HorizontalScrollbarSize = 10;
            this.tpRoutingSettings.Location = new System.Drawing.Point(4, 34);
            this.tpRoutingSettings.Name = "tpRoutingSettings";
            this.tpRoutingSettings.Size = new System.Drawing.Size(702, 251);
            this.tpRoutingSettings.TabIndex = 4;
            this.tpRoutingSettings.Text = "Routing";
            this.tpRoutingSettings.VerticalScrollbarBarColor = true;
            this.tpRoutingSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tpRoutingSettings.VerticalScrollbarSize = 10;
            // 
            // cbRoutingStartup
            // 
            this.cbRoutingStartup.AutoSize = true;
            this.cbRoutingStartup.Location = new System.Drawing.Point(4, 87);
            this.cbRoutingStartup.Name = "cbRoutingStartup";
            this.cbRoutingStartup.Size = new System.Drawing.Size(182, 15);
            this.cbRoutingStartup.TabIndex = 5;
            this.cbRoutingStartup.Text = "Run routing service on startup";
            this.cbRoutingStartup.UseSelectable = true;
            // 
            // spinnerRouting
            // 
            this.spinnerRouting.Location = new System.Drawing.Point(90, 48);
            this.spinnerRouting.Maximum = 100;
            this.spinnerRouting.Name = "spinnerRouting";
            this.spinnerRouting.Size = new System.Drawing.Size(16, 16);
            this.spinnerRouting.Speed = 2F;
            this.spinnerRouting.TabIndex = 4;
            this.spinnerRouting.UseSelectable = true;
            this.spinnerRouting.Value = 15;
            this.spinnerRouting.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(4, 22);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(110, 19);
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "IP routing service";
            // 
            // tglRouting
            // 
            this.tglRouting.AutoSize = true;
            this.tglRouting.Location = new System.Drawing.Point(4, 48);
            this.tglRouting.Name = "tglRouting";
            this.tglRouting.Size = new System.Drawing.Size(80, 17);
            this.tglRouting.TabIndex = 2;
            this.tglRouting.Text = "Aus";
            this.tglRouting.UseSelectable = true;
            this.tglRouting.CheckedChanged += new System.EventHandler(this.TglRouting_CheckedChanged);
            // 
            // tpScanSettings
            // 
            this.tpScanSettings.Controls.Add(this.metroLabel6);
            this.tpScanSettings.Controls.Add(this.metroLabel5);
            this.tpScanSettings.Controls.Add(this.tbScanReplyTimeout);
            this.tpScanSettings.Controls.Add(this.tbScanSendInterval);
            this.tpScanSettings.Controls.Add(this.metroLabel4);
            this.tpScanSettings.Controls.Add(this.metroLabel3);
            this.tpScanSettings.HorizontalScrollbarBarColor = true;
            this.tpScanSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tpScanSettings.HorizontalScrollbarSize = 10;
            this.tpScanSettings.Location = new System.Drawing.Point(4, 34);
            this.tpScanSettings.Name = "tpScanSettings";
            this.tpScanSettings.Size = new System.Drawing.Size(702, 251);
            this.tpScanSettings.TabIndex = 0;
            this.tpScanSettings.Text = "Scan";
            this.tpScanSettings.VerticalScrollbarBarColor = true;
            this.tpScanSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tpScanSettings.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(170, 105);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(26, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "ms";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(171, 47);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(26, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "ms";
            // 
            // tbScanReplyTimeout
            // 
            // 
            // 
            // 
            this.tbScanReplyTimeout.CustomButton.Image = null;
            this.tbScanReplyTimeout.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.tbScanReplyTimeout.CustomButton.Name = "";
            this.tbScanReplyTimeout.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbScanReplyTimeout.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbScanReplyTimeout.CustomButton.TabIndex = 1;
            this.tbScanReplyTimeout.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbScanReplyTimeout.CustomButton.UseSelectable = true;
            this.tbScanReplyTimeout.CustomButton.Visible = false;
            this.tbScanReplyTimeout.Lines = new string[0];
            this.tbScanReplyTimeout.Location = new System.Drawing.Point(3, 101);
            this.tbScanReplyTimeout.MaxLength = 32767;
            this.tbScanReplyTimeout.Name = "tbScanReplyTimeout";
            this.tbScanReplyTimeout.PasswordChar = '\0';
            this.tbScanReplyTimeout.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbScanReplyTimeout.SelectedText = "";
            this.tbScanReplyTimeout.SelectionLength = 0;
            this.tbScanReplyTimeout.SelectionStart = 0;
            this.tbScanReplyTimeout.ShortcutsEnabled = true;
            this.tbScanReplyTimeout.Size = new System.Drawing.Size(161, 23);
            this.tbScanReplyTimeout.TabIndex = 7;
            this.tbScanReplyTimeout.UseSelectable = true;
            this.tbScanReplyTimeout.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbScanReplyTimeout.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbScanSendInterval
            // 
            // 
            // 
            // 
            this.tbScanSendInterval.CustomButton.Image = null;
            this.tbScanSendInterval.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.tbScanSendInterval.CustomButton.Name = "";
            this.tbScanSendInterval.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbScanSendInterval.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbScanSendInterval.CustomButton.TabIndex = 1;
            this.tbScanSendInterval.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbScanSendInterval.CustomButton.UseSelectable = true;
            this.tbScanSendInterval.CustomButton.Visible = false;
            this.tbScanSendInterval.Lines = new string[0];
            this.tbScanSendInterval.Location = new System.Drawing.Point(3, 44);
            this.tbScanSendInterval.MaxLength = 32767;
            this.tbScanSendInterval.Name = "tbScanSendInterval";
            this.tbScanSendInterval.PasswordChar = '\0';
            this.tbScanSendInterval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbScanSendInterval.SelectedText = "";
            this.tbScanSendInterval.SelectionLength = 0;
            this.tbScanSendInterval.SelectionStart = 0;
            this.tbScanSendInterval.ShortcutsEnabled = true;
            this.tbScanSendInterval.Size = new System.Drawing.Size(161, 23);
            this.tbScanSendInterval.TabIndex = 7;
            this.tbScanSendInterval.UseSelectable = true;
            this.tbScanSendInterval.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbScanSendInterval.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Reply Timeout";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 22);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Send Interval";
            // 
            // tpSpoofSettings
            // 
            this.tpSpoofSettings.Controls.Add(this.metroLabel13);
            this.tpSpoofSettings.Controls.Add(this.metroLabel8);
            this.tpSpoofSettings.Controls.Add(this.tbSpoofRestoreSendInterval);
            this.tpSpoofSettings.Controls.Add(this.metroLabel12);
            this.tpSpoofSettings.Controls.Add(this.tbSpoofRestoreSendCount);
            this.tpSpoofSettings.Controls.Add(this.metroLabel10);
            this.tpSpoofSettings.Controls.Add(this.tbSpoofSendInterval);
            this.tpSpoofSettings.Controls.Add(this.metroLabel9);
            this.tpSpoofSettings.HorizontalScrollbarBarColor = true;
            this.tpSpoofSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSpoofSettings.HorizontalScrollbarSize = 10;
            this.tpSpoofSettings.Location = new System.Drawing.Point(4, 34);
            this.tpSpoofSettings.Name = "tpSpoofSettings";
            this.tpSpoofSettings.Size = new System.Drawing.Size(702, 251);
            this.tpSpoofSettings.TabIndex = 1;
            this.tpSpoofSettings.Text = "Spoof";
            this.tpSpoofSettings.VerticalScrollbarBarColor = true;
            this.tpSpoofSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tpSpoofSettings.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(170, 162);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(26, 19);
            this.metroLabel13.TabIndex = 11;
            this.metroLabel13.Text = "ms";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(170, 48);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(26, 19);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "ms";
            // 
            // tbSpoofRestoreSendInterval
            // 
            // 
            // 
            // 
            this.tbSpoofRestoreSendInterval.CustomButton.Image = null;
            this.tbSpoofRestoreSendInterval.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.tbSpoofRestoreSendInterval.CustomButton.Name = "";
            this.tbSpoofRestoreSendInterval.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSpoofRestoreSendInterval.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSpoofRestoreSendInterval.CustomButton.TabIndex = 1;
            this.tbSpoofRestoreSendInterval.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSpoofRestoreSendInterval.CustomButton.UseSelectable = true;
            this.tbSpoofRestoreSendInterval.CustomButton.Visible = false;
            this.tbSpoofRestoreSendInterval.Lines = new string[0];
            this.tbSpoofRestoreSendInterval.Location = new System.Drawing.Point(3, 158);
            this.tbSpoofRestoreSendInterval.MaxLength = 32767;
            this.tbSpoofRestoreSendInterval.Name = "tbSpoofRestoreSendInterval";
            this.tbSpoofRestoreSendInterval.PasswordChar = '\0';
            this.tbSpoofRestoreSendInterval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSpoofRestoreSendInterval.SelectedText = "";
            this.tbSpoofRestoreSendInterval.SelectionLength = 0;
            this.tbSpoofRestoreSendInterval.SelectionStart = 0;
            this.tbSpoofRestoreSendInterval.ShortcutsEnabled = true;
            this.tbSpoofRestoreSendInterval.Size = new System.Drawing.Size(161, 23);
            this.tbSpoofRestoreSendInterval.TabIndex = 10;
            this.tbSpoofRestoreSendInterval.UseSelectable = true;
            this.tbSpoofRestoreSendInterval.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSpoofRestoreSendInterval.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(3, 136);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(133, 19);
            this.metroLabel12.TabIndex = 9;
            this.metroLabel12.Text = "Restore Send Interval";
            // 
            // tbSpoofRestoreSendCount
            // 
            // 
            // 
            // 
            this.tbSpoofRestoreSendCount.CustomButton.Image = null;
            this.tbSpoofRestoreSendCount.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.tbSpoofRestoreSendCount.CustomButton.Name = "";
            this.tbSpoofRestoreSendCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSpoofRestoreSendCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSpoofRestoreSendCount.CustomButton.TabIndex = 1;
            this.tbSpoofRestoreSendCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSpoofRestoreSendCount.CustomButton.UseSelectable = true;
            this.tbSpoofRestoreSendCount.CustomButton.Visible = false;
            this.tbSpoofRestoreSendCount.Lines = new string[0];
            this.tbSpoofRestoreSendCount.Location = new System.Drawing.Point(3, 101);
            this.tbSpoofRestoreSendCount.MaxLength = 32767;
            this.tbSpoofRestoreSendCount.Name = "tbSpoofRestoreSendCount";
            this.tbSpoofRestoreSendCount.PasswordChar = '\0';
            this.tbSpoofRestoreSendCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSpoofRestoreSendCount.SelectedText = "";
            this.tbSpoofRestoreSendCount.SelectionLength = 0;
            this.tbSpoofRestoreSendCount.SelectionStart = 0;
            this.tbSpoofRestoreSendCount.ShortcutsEnabled = true;
            this.tbSpoofRestoreSendCount.Size = new System.Drawing.Size(161, 23);
            this.tbSpoofRestoreSendCount.TabIndex = 10;
            this.tbSpoofRestoreSendCount.UseSelectable = true;
            this.tbSpoofRestoreSendCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSpoofRestoreSendCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 79);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(125, 19);
            this.metroLabel10.TabIndex = 9;
            this.metroLabel10.Text = "Restore Send Count";
            // 
            // tbSpoofSendInterval
            // 
            // 
            // 
            // 
            this.tbSpoofSendInterval.CustomButton.Image = null;
            this.tbSpoofSendInterval.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.tbSpoofSendInterval.CustomButton.Name = "";
            this.tbSpoofSendInterval.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSpoofSendInterval.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSpoofSendInterval.CustomButton.TabIndex = 1;
            this.tbSpoofSendInterval.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSpoofSendInterval.CustomButton.UseSelectable = true;
            this.tbSpoofSendInterval.CustomButton.Visible = false;
            this.tbSpoofSendInterval.Lines = new string[0];
            this.tbSpoofSendInterval.Location = new System.Drawing.Point(3, 44);
            this.tbSpoofSendInterval.MaxLength = 32767;
            this.tbSpoofSendInterval.Name = "tbSpoofSendInterval";
            this.tbSpoofSendInterval.PasswordChar = '\0';
            this.tbSpoofSendInterval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSpoofSendInterval.SelectedText = "";
            this.tbSpoofSendInterval.SelectionLength = 0;
            this.tbSpoofSendInterval.SelectionStart = 0;
            this.tbSpoofSendInterval.ShortcutsEnabled = true;
            this.tbSpoofSendInterval.Size = new System.Drawing.Size(161, 23);
            this.tbSpoofSendInterval.TabIndex = 10;
            this.tbSpoofSendInterval.UseSelectable = true;
            this.tbSpoofSendInterval.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSpoofSendInterval.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 22);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(85, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Send Interval";
            // 
            // tpAppearanceSettings
            // 
            this.tpAppearanceSettings.Controls.Add(this.cmbColorStyle);
            this.tpAppearanceSettings.Controls.Add(this.metroLabel1);
            this.tpAppearanceSettings.HorizontalScrollbarBarColor = true;
            this.tpAppearanceSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAppearanceSettings.HorizontalScrollbarSize = 10;
            this.tpAppearanceSettings.Location = new System.Drawing.Point(4, 34);
            this.tpAppearanceSettings.Name = "tpAppearanceSettings";
            this.tpAppearanceSettings.Size = new System.Drawing.Size(702, 251);
            this.tpAppearanceSettings.TabIndex = 2;
            this.tpAppearanceSettings.Text = "Appearance";
            this.tpAppearanceSettings.VerticalScrollbarBarColor = true;
            this.tpAppearanceSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tpAppearanceSettings.VerticalScrollbarSize = 10;
            // 
            // cmbColorStyle
            // 
            this.cmbColorStyle.FormattingEnabled = true;
            this.cmbColorStyle.ItemHeight = 23;
            this.cmbColorStyle.Location = new System.Drawing.Point(3, 44);
            this.cmbColorStyle.Name = "cmbColorStyle";
            this.cmbColorStyle.Size = new System.Drawing.Size(161, 29);
            this.cmbColorStyle.TabIndex = 3;
            this.cmbColorStyle.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Color Style";
            // 
            // tpOtherSettings
            // 
            this.tpOtherSettings.Controls.Add(this.metroLabel7);
            this.tpOtherSettings.Controls.Add(this.tbBandwidthMonitorUpdateInterval);
            this.tpOtherSettings.Controls.Add(this.metroLabel2);
            this.tpOtherSettings.HorizontalScrollbarBarColor = true;
            this.tpOtherSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tpOtherSettings.HorizontalScrollbarSize = 10;
            this.tpOtherSettings.Location = new System.Drawing.Point(4, 34);
            this.tpOtherSettings.Name = "tpOtherSettings";
            this.tpOtherSettings.Size = new System.Drawing.Size(702, 251);
            this.tpOtherSettings.TabIndex = 3;
            this.tpOtherSettings.Text = "Other";
            this.tpOtherSettings.VerticalScrollbarBarColor = true;
            this.tpOtherSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tpOtherSettings.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(170, 48);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(26, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "ms";
            // 
            // tbBandwidthMonitorUpdateInterval
            // 
            // 
            // 
            // 
            this.tbBandwidthMonitorUpdateInterval.CustomButton.Image = null;
            this.tbBandwidthMonitorUpdateInterval.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.tbBandwidthMonitorUpdateInterval.CustomButton.Name = "";
            this.tbBandwidthMonitorUpdateInterval.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbBandwidthMonitorUpdateInterval.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbBandwidthMonitorUpdateInterval.CustomButton.TabIndex = 1;
            this.tbBandwidthMonitorUpdateInterval.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbBandwidthMonitorUpdateInterval.CustomButton.UseSelectable = true;
            this.tbBandwidthMonitorUpdateInterval.CustomButton.Visible = false;
            this.tbBandwidthMonitorUpdateInterval.Lines = new string[0];
            this.tbBandwidthMonitorUpdateInterval.Location = new System.Drawing.Point(3, 44);
            this.tbBandwidthMonitorUpdateInterval.MaxLength = 32767;
            this.tbBandwidthMonitorUpdateInterval.Name = "tbBandwidthMonitorUpdateInterval";
            this.tbBandwidthMonitorUpdateInterval.PasswordChar = '\0';
            this.tbBandwidthMonitorUpdateInterval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBandwidthMonitorUpdateInterval.SelectedText = "";
            this.tbBandwidthMonitorUpdateInterval.SelectionLength = 0;
            this.tbBandwidthMonitorUpdateInterval.SelectionStart = 0;
            this.tbBandwidthMonitorUpdateInterval.ShortcutsEnabled = true;
            this.tbBandwidthMonitorUpdateInterval.Size = new System.Drawing.Size(161, 23);
            this.tbBandwidthMonitorUpdateInterval.TabIndex = 11;
            this.tbBandwidthMonitorUpdateInterval.UseSelectable = true;
            this.tbBandwidthMonitorUpdateInterval.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbBandwidthMonitorUpdateInterval.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(164, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Bandwidth Update Interval";
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.metroLabel17);
            this.tpAbout.Controls.Add(this.lnkCredits);
            this.tpAbout.Controls.Add(this.metroLabel16);
            this.tpAbout.Controls.Add(this.lnkGitHubPage);
            this.tpAbout.Controls.Add(this.lnkEvilLimiter);
            this.tpAbout.Controls.Add(this.metroLabel15);
            this.tpAbout.Controls.Add(this.metroLabel14);
            this.tpAbout.HorizontalScrollbarBarColor = true;
            this.tpAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAbout.HorizontalScrollbarSize = 10;
            this.tpAbout.Location = new System.Drawing.Point(4, 38);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(710, 334);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            this.tpAbout.VerticalScrollbarBarColor = true;
            this.tpAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tpAbout.VerticalScrollbarSize = 10;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(3, 123);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(279, 38);
            this.metroLabel17.TabIndex = 6;
            this.metroLabel17.Text = "by bitbrute\r\nCopyright © 2019 bitbrute. All rights reserved.";
            // 
            // lnkCredits
            // 
            this.lnkCredits.Location = new System.Drawing.Point(3, 191);
            this.lnkCredits.Name = "lnkCredits";
            this.lnkCredits.Size = new System.Drawing.Size(74, 23);
            this.lnkCredits.TabIndex = 5;
            this.lnkCredits.Text = "Roll credits";
            this.lnkCredits.UseSelectable = true;
            this.lnkCredits.Click += new System.EventHandler(this.LnkCredits_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(3, 13);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(531, 38);
            this.metroLabel16.TabIndex = 4;
            this.metroLabel16.Text = "EvilLimiter allows you to limit the bandwidth of devices on your network without " +
    "having an\r\nphysical or administrative access.";
            // 
            // lnkGitHubPage
            // 
            this.lnkGitHubPage.Location = new System.Drawing.Point(308, 87);
            this.lnkGitHubPage.Name = "lnkGitHubPage";
            this.lnkGitHubPage.Size = new System.Drawing.Size(77, 19);
            this.lnkGitHubPage.TabIndex = 3;
            this.lnkGitHubPage.Text = "GitHub page";
            this.lnkGitHubPage.UseSelectable = true;
            this.lnkGitHubPage.Click += new System.EventHandler(this.LnkGitHubPage_Click);
            // 
            // lnkEvilLimiter
            // 
            this.lnkEvilLimiter.Location = new System.Drawing.Point(354, 68);
            this.lnkEvilLimiter.Name = "lnkEvilLimiter";
            this.lnkEvilLimiter.Size = new System.Drawing.Size(66, 19);
            this.lnkEvilLimiter.TabIndex = 3;
            this.lnkEvilLimiter.Text = "EvilLimiter";
            this.lnkEvilLimiter.UseSelectable = true;
            this.lnkEvilLimiter.Click += new System.EventHandler(this.LnkEvilLimiter_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(3, 86);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(389, 19);
            this.metroLabel15.TabIndex = 2;
            this.metroLabel15.Text = "A guide on how to use this tool is presented on the                    .";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(3, 67);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(427, 19);
            this.metroLabel14.TabIndex = 2;
            this.metroLabel14.Text = "This is the Windows version of the linux command-line tool                  .";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 478);
            this.Controls.Add(this.tcHosts);
            this.Controls.Add(this.lblVersion);
            this.Name = "FrmMain";
            this.Text = "EvilLimiter for Windows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.cmsHosts.ResumeLayout(false);
            this.tcHosts.ResumeLayout(false);
            this.tpHosts.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tcSettings.ResumeLayout(false);
            this.tpRoutingSettings.ResumeLayout(false);
            this.tpRoutingSettings.PerformLayout();
            this.tpScanSettings.ResumeLayout(false);
            this.tpScanSettings.PerformLayout();
            this.tpSpoofSettings.ResumeLayout(false);
            this.tpSpoofSettings.PerformLayout();
            this.tpAppearanceSettings.ResumeLayout(false);
            this.tpAppearanceSettings.PerformLayout();
            this.tpOtherSettings.ResumeLayout(false);
            this.tpOtherSettings.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnScan;
        private MetroFramework.Controls.MetroLabel lblVersion;
        private MetroFramework.Controls.MetroContextMenu cmsHosts;
        private System.Windows.Forms.ToolStripMenuItem tsmiLimit;
        private System.Windows.Forms.ToolStripMenuItem tsmiFree;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private EvilLimiter.Windows.Controls.ListViewNF lvwHosts;
        private System.Windows.Forms.ColumnHeader chIp;
        private System.Windows.Forms.ColumnHeader chMac;
        private System.Windows.Forms.ColumnHeader chHostName;
        private MetroFramework.Controls.MetroTabControl tcHosts;
        private MetroFramework.Controls.MetroTabPage tpHosts;
        private MetroFramework.Controls.MetroTabPage tpSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlock;
        private System.Windows.Forms.ColumnHeader chUpload;
        private System.Windows.Forms.ColumnHeader chDownload;
        private MetroFramework.Controls.MetroTabControl tcSettings;
        private MetroFramework.Controls.MetroTabPage tpScanSettings;
        private MetroFramework.Controls.MetroTabPage tpSpoofSettings;
        private MetroFramework.Controls.MetroTabPage tpAppearanceSettings;
        private MetroFramework.Controls.MetroComboBox cmbColorStyle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbScanSendInterval;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbScanReplyTimeout;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox tbSpoofSendInterval;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox tbSpoofRestoreSendCount;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tbSpoofRestoreSendInterval;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTabPage tpOtherSettings;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbBandwidthMonitorUpdateInterval;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnApplySettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private MetroFramework.Controls.MetroTabPage tpRoutingSettings;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroToggle tglRouting;
        private MetroFramework.Controls.MetroProgressSpinner spinnerRouting;
        private MetroFramework.Controls.MetroCheckBox cbRoutingStartup;
        private MetroFramework.Controls.MetroTabPage tpAbout;
        private MetroFramework.Controls.MetroLink lnkEvilLimiter;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLink lnkCredits;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLink lnkGitHubPage;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel17;
    }
}