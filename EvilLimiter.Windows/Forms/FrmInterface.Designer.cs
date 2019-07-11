namespace EvilLimiter.Windows.Forms
{
    partial class FrmInterface
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbInterfaces = new MetroFramework.Controls.MetroComboBox();
            this.tbGatewayIp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbGatewayMac = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbNetmask = new MetroFramework.Controls.MetroTextBox();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblInterfaceAddress = new MetroFramework.Controls.MetroLabel();
            this.spinStatus = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Interface";
            // 
            // cbInterfaces
            // 
            this.cbInterfaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInterfaces.FormattingEnabled = true;
            this.cbInterfaces.ItemHeight = 23;
            this.cbInterfaces.Location = new System.Drawing.Point(23, 107);
            this.cbInterfaces.Name = "cbInterfaces";
            this.cbInterfaces.Size = new System.Drawing.Size(368, 29);
            this.cbInterfaces.TabIndex = 1;
            this.cbInterfaces.UseSelectable = true;
            this.cbInterfaces.SelectedIndexChanged += new System.EventHandler(this.CbInterfaces_SelectedIndexChanged);
            // 
            // tbGatewayIp
            // 
            this.tbGatewayIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbGatewayIp.CustomButton.Image = null;
            this.tbGatewayIp.CustomButton.Location = new System.Drawing.Point(346, 1);
            this.tbGatewayIp.CustomButton.Name = "";
            this.tbGatewayIp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbGatewayIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbGatewayIp.CustomButton.TabIndex = 1;
            this.tbGatewayIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbGatewayIp.CustomButton.UseSelectable = true;
            this.tbGatewayIp.CustomButton.Visible = false;
            this.tbGatewayIp.Lines = new string[0];
            this.tbGatewayIp.Location = new System.Drawing.Point(23, 224);
            this.tbGatewayIp.MaxLength = 32767;
            this.tbGatewayIp.Name = "tbGatewayIp";
            this.tbGatewayIp.PasswordChar = '\0';
            this.tbGatewayIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbGatewayIp.SelectedText = "";
            this.tbGatewayIp.SelectionLength = 0;
            this.tbGatewayIp.SelectionStart = 0;
            this.tbGatewayIp.ShortcutsEnabled = true;
            this.tbGatewayIp.Size = new System.Drawing.Size(368, 23);
            this.tbGatewayIp.TabIndex = 3;
            this.tbGatewayIp.UseSelectable = true;
            this.tbGatewayIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbGatewayIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 202);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Gateway IP";
            // 
            // tbGatewayMac
            // 
            this.tbGatewayMac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbGatewayMac.CustomButton.Image = null;
            this.tbGatewayMac.CustomButton.Location = new System.Drawing.Point(346, 1);
            this.tbGatewayMac.CustomButton.Name = "";
            this.tbGatewayMac.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbGatewayMac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbGatewayMac.CustomButton.TabIndex = 1;
            this.tbGatewayMac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbGatewayMac.CustomButton.UseSelectable = true;
            this.tbGatewayMac.CustomButton.Visible = false;
            this.tbGatewayMac.Lines = new string[0];
            this.tbGatewayMac.Location = new System.Drawing.Point(23, 281);
            this.tbGatewayMac.MaxLength = 32767;
            this.tbGatewayMac.Name = "tbGatewayMac";
            this.tbGatewayMac.PasswordChar = '\0';
            this.tbGatewayMac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbGatewayMac.SelectedText = "";
            this.tbGatewayMac.SelectionLength = 0;
            this.tbGatewayMac.SelectionStart = 0;
            this.tbGatewayMac.ShortcutsEnabled = true;
            this.tbGatewayMac.Size = new System.Drawing.Size(368, 23);
            this.tbGatewayMac.TabIndex = 3;
            this.tbGatewayMac.UseSelectable = true;
            this.tbGatewayMac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbGatewayMac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 259);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(92, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Gateway MAC";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 316);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Netmask";
            // 
            // tbNetmask
            // 
            this.tbNetmask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbNetmask.CustomButton.Image = null;
            this.tbNetmask.CustomButton.Location = new System.Drawing.Point(346, 1);
            this.tbNetmask.CustomButton.Name = "";
            this.tbNetmask.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNetmask.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNetmask.CustomButton.TabIndex = 1;
            this.tbNetmask.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNetmask.CustomButton.UseSelectable = true;
            this.tbNetmask.CustomButton.Visible = false;
            this.tbNetmask.Lines = new string[0];
            this.tbNetmask.Location = new System.Drawing.Point(23, 338);
            this.tbNetmask.MaxLength = 32767;
            this.tbNetmask.Name = "tbNetmask";
            this.tbNetmask.PasswordChar = '\0';
            this.tbNetmask.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNetmask.SelectedText = "";
            this.tbNetmask.SelectionLength = 0;
            this.tbNetmask.SelectionStart = 0;
            this.tbNetmask.ShortcutsEnabled = true;
            this.tbNetmask.Size = new System.Drawing.Size(368, 23);
            this.tbNetmask.TabIndex = 3;
            this.tbNetmask.UseSelectable = true;
            this.tbNetmask.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNetmask.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Highlight = true;
            this.btnOk.Location = new System.Drawing.Point(316, 406);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseSelectable = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Interface Address:";
            // 
            // lblInterfaceAddress
            // 
            this.lblInterfaceAddress.AutoSize = true;
            this.lblInterfaceAddress.Location = new System.Drawing.Point(142, 148);
            this.lblInterfaceAddress.Name = "lblInterfaceAddress";
            this.lblInterfaceAddress.Size = new System.Drawing.Size(82, 19);
            this.lblInterfaceAddress.TabIndex = 6;
            this.lblInterfaceAddress.Text = "Not selected";
            // 
            // spinStatus
            // 
            this.spinStatus.Location = new System.Drawing.Point(23, 412);
            this.spinStatus.Maximum = 100;
            this.spinStatus.Name = "spinStatus";
            this.spinStatus.Size = new System.Drawing.Size(16, 16);
            this.spinStatus.Speed = 2F;
            this.spinStatus.TabIndex = 7;
            this.spinStatus.UseSelectable = true;
            this.spinStatus.Value = 30;
            this.spinStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(45, 409);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 0);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Visible = false;
            // 
            // FrmInterface
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 452);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.spinStatus);
            this.Controls.Add(this.lblInterfaceAddress);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbNetmask);
            this.Controls.Add(this.tbGatewayMac);
            this.Controls.Add(this.tbGatewayIp);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbInterfaces);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmInterface";
            this.Text = "Network Interface...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbInterfaces;
        private MetroFramework.Controls.MetroTextBox tbGatewayIp;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbGatewayMac;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbNetmask;
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblInterfaceAddress;
        private MetroFramework.Controls.MetroProgressSpinner spinStatus;
        private MetroFramework.Controls.MetroLabel lblStatus;
    }
}