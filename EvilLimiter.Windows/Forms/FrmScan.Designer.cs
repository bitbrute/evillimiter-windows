namespace EvilLimiter.Windows.Forms
{
    partial class FrmScan
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
            this.rbtnEntireRange = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnCustomRange = new MetroFramework.Controls.MetroRadioButton();
            this.lblSubnetRange = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbIpRange = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnScan = new MetroFramework.Controls.MetroButton();
            this.pbScan = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // rbtnEntireRange
            // 
            this.rbtnEntireRange.AutoSize = true;
            this.rbtnEntireRange.Checked = true;
            this.rbtnEntireRange.Location = new System.Drawing.Point(23, 72);
            this.rbtnEntireRange.Name = "rbtnEntireRange";
            this.rbtnEntireRange.Size = new System.Drawing.Size(120, 15);
            this.rbtnEntireRange.TabIndex = 0;
            this.rbtnEntireRange.TabStop = true;
            this.rbtnEntireRange.Text = "Scan entire subnet";
            this.rbtnEntireRange.UseSelectable = true;
            // 
            // rbtnCustomRange
            // 
            this.rbtnCustomRange.AutoSize = true;
            this.rbtnCustomRange.Location = new System.Drawing.Point(23, 127);
            this.rbtnCustomRange.Name = "rbtnCustomRange";
            this.rbtnCustomRange.Size = new System.Drawing.Size(137, 15);
            this.rbtnCustomRange.TabIndex = 1;
            this.rbtnCustomRange.Text = "Scan custom IP range";
            this.rbtnCustomRange.UseSelectable = true;
            // 
            // lblSubnetRange
            // 
            this.lblSubnetRange.AutoSize = true;
            this.lblSubnetRange.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSubnetRange.Location = new System.Drawing.Point(98, 90);
            this.lblSubnetRange.Name = "lblSubnetRange";
            this.lblSubnetRange.Size = new System.Drawing.Size(143, 15);
            this.lblSubnetRange.TabIndex = 2;
            this.lblSubnetRange.Text = "192.168.178.0/255.255.255.0";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(40, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 15);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "IP range:";
            // 
            // tbIpRange
            // 
            // 
            // 
            // 
            this.tbIpRange.CustomButton.Image = null;
            this.tbIpRange.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.tbIpRange.CustomButton.Name = "";
            this.tbIpRange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbIpRange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbIpRange.CustomButton.TabIndex = 1;
            this.tbIpRange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbIpRange.CustomButton.UseSelectable = true;
            this.tbIpRange.CustomButton.Visible = false;
            this.tbIpRange.Lines = new string[0];
            this.tbIpRange.Location = new System.Drawing.Point(98, 148);
            this.tbIpRange.MaxLength = 32767;
            this.tbIpRange.Name = "tbIpRange";
            this.tbIpRange.PasswordChar = '\0';
            this.tbIpRange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIpRange.SelectedText = "";
            this.tbIpRange.SelectionLength = 0;
            this.tbIpRange.SelectionStart = 0;
            this.tbIpRange.ShortcutsEnabled = true;
            this.tbIpRange.Size = new System.Drawing.Size(171, 23);
            this.tbIpRange.TabIndex = 3;
            this.tbIpRange.UseSelectable = true;
            this.tbIpRange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbIpRange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(40, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 15);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "IP range:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(98, 174);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(171, 45);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "e.g. 192.168.0.0 - 192.168.178.0.50\r\n        192.168.0.0/24\r\n        192.168.0.0/" +
    "255.255.255.0";
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Highlight = true;
            this.btnScan.Location = new System.Drawing.Point(196, 262);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 4;
            this.btnScan.Text = "Scan";
            this.btnScan.UseSelectable = true;
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // pbScan
            // 
            this.pbScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScan.Location = new System.Drawing.Point(23, 262);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(165, 23);
            this.pbScan.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(23, 244);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 15);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblStatus.Location = new System.Drawing.Point(70, 244);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 0);
            this.lblStatus.TabIndex = 6;
            // 
            // FrmScan
            // 
            this.AcceptButton = this.btnScan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 308);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.tbIpRange);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblSubnetRange);
            this.Controls.Add(this.rbtnCustomRange);
            this.Controls.Add(this.rbtnEntireRange);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmScan";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Host Scan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmScan_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rbtnEntireRange;
        private MetroFramework.Controls.MetroRadioButton rbtnCustomRange;
        private MetroFramework.Controls.MetroLabel lblSubnetRange;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbIpRange;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnScan;
        private MetroFramework.Controls.MetroProgressBar pbScan;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblStatus;
    }
}