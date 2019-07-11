namespace EvilLimiter.Windows.Forms
{
    partial class FrmAddHost
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
            this.tbIpAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbMacAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbHostName = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "IP address";
            // 
            // tbIpAddress
            // 
            // 
            // 
            // 
            this.tbIpAddress.CustomButton.Image = null;
            this.tbIpAddress.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbIpAddress.CustomButton.Name = "";
            this.tbIpAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbIpAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbIpAddress.CustomButton.TabIndex = 1;
            this.tbIpAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbIpAddress.CustomButton.UseSelectable = true;
            this.tbIpAddress.CustomButton.Visible = false;
            this.tbIpAddress.Lines = new string[0];
            this.tbIpAddress.Location = new System.Drawing.Point(23, 92);
            this.tbIpAddress.MaxLength = 32767;
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.PasswordChar = '\0';
            this.tbIpAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIpAddress.SelectedText = "";
            this.tbIpAddress.SelectionLength = 0;
            this.tbIpAddress.SelectionStart = 0;
            this.tbIpAddress.ShortcutsEnabled = true;
            this.tbIpAddress.Size = new System.Drawing.Size(191, 23);
            this.tbIpAddress.TabIndex = 0;
            this.tbIpAddress.UseSelectable = true;
            this.tbIpAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbIpAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "MAC address";
            // 
            // tbMacAddress
            // 
            // 
            // 
            // 
            this.tbMacAddress.CustomButton.Image = null;
            this.tbMacAddress.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbMacAddress.CustomButton.Name = "";
            this.tbMacAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMacAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMacAddress.CustomButton.TabIndex = 1;
            this.tbMacAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMacAddress.CustomButton.UseSelectable = true;
            this.tbMacAddress.CustomButton.Visible = false;
            this.tbMacAddress.Lines = new string[0];
            this.tbMacAddress.Location = new System.Drawing.Point(23, 149);
            this.tbMacAddress.MaxLength = 32767;
            this.tbMacAddress.Name = "tbMacAddress";
            this.tbMacAddress.PasswordChar = '\0';
            this.tbMacAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMacAddress.SelectedText = "";
            this.tbMacAddress.SelectionLength = 0;
            this.tbMacAddress.SelectionStart = 0;
            this.tbMacAddress.ShortcutsEnabled = true;
            this.tbMacAddress.Size = new System.Drawing.Size(191, 23);
            this.tbMacAddress.TabIndex = 1;
            this.tbMacAddress.UseSelectable = true;
            this.tbMacAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMacAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 184);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Hostname (optional)";
            // 
            // tbHostName
            // 
            // 
            // 
            // 
            this.tbHostName.CustomButton.Image = null;
            this.tbHostName.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbHostName.CustomButton.Name = "";
            this.tbHostName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbHostName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbHostName.CustomButton.TabIndex = 1;
            this.tbHostName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbHostName.CustomButton.UseSelectable = true;
            this.tbHostName.CustomButton.Visible = false;
            this.tbHostName.Lines = new string[0];
            this.tbHostName.Location = new System.Drawing.Point(23, 206);
            this.tbHostName.MaxLength = 32767;
            this.tbHostName.Name = "tbHostName";
            this.tbHostName.PasswordChar = '\0';
            this.tbHostName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbHostName.SelectedText = "";
            this.tbHostName.SelectionLength = 0;
            this.tbHostName.SelectionStart = 0;
            this.tbHostName.ShortcutsEnabled = true;
            this.tbHostName.Size = new System.Drawing.Size(191, 23);
            this.tbHostName.TabIndex = 2;
            this.tbHostName.UseSelectable = true;
            this.tbHostName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbHostName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Highlight = true;
            this.btnAdd.Location = new System.Drawing.Point(133, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FrmAddHost
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 310);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbHostName);
            this.Controls.Add(this.tbMacAddress);
            this.Controls.Add(this.tbIpAddress);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddHost";
            this.Resizable = false;
            this.Text = "Add Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbIpAddress;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbMacAddress;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbHostName;
        private MetroFramework.Controls.MetroButton btnAdd;
    }
}