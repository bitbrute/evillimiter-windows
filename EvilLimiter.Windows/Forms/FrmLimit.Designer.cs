namespace EvilLimiter.Windows.Forms
{
    partial class FrmLimit
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
            this.tbUploadRate = new MetroFramework.Controls.MetroTextBox();
            this.cmbUploadRate = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbUploadBurst = new MetroFramework.Controls.MetroTextBox();
            this.cmbUploadBurst = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tglUpload = new MetroFramework.Controls.MetroToggle();
            this.tglDownload = new MetroFramework.Controls.MetroToggle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbDownloadRate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tbDownloadBurst = new MetroFramework.Controls.MetroTextBox();
            this.cmbDownloadRate = new MetroFramework.Controls.MetroComboBox();
            this.cmbDownloadBurst = new MetroFramework.Controls.MetroComboBox();
            this.cbUploadBurst = new MetroFramework.Controls.MetroCheckBox();
            this.cbDownloadBurst = new MetroFramework.Controls.MetroCheckBox();
            this.btnLimit = new MetroFramework.Controls.MetroButton();
            this.pnlUpload = new MetroFramework.Controls.MetroPanel();
            this.pnlDownload = new MetroFramework.Controls.MetroPanel();
            this.pnlUpload.SuspendLayout();
            this.pnlDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.Location = new System.Drawing.Point(1, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Rate";
            // 
            // tbUploadRate
            // 
            // 
            // 
            // 
            this.tbUploadRate.CustomButton.Image = null;
            this.tbUploadRate.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.tbUploadRate.CustomButton.Name = "";
            this.tbUploadRate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUploadRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUploadRate.CustomButton.TabIndex = 1;
            this.tbUploadRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUploadRate.CustomButton.UseSelectable = true;
            this.tbUploadRate.CustomButton.Visible = false;
            this.tbUploadRate.Lines = new string[0];
            this.tbUploadRate.Location = new System.Drawing.Point(1, 26);
            this.tbUploadRate.MaxLength = 32767;
            this.tbUploadRate.Name = "tbUploadRate";
            this.tbUploadRate.PasswordChar = '\0';
            this.tbUploadRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUploadRate.SelectedText = "";
            this.tbUploadRate.SelectionLength = 0;
            this.tbUploadRate.SelectionStart = 0;
            this.tbUploadRate.ShortcutsEnabled = true;
            this.tbUploadRate.Size = new System.Drawing.Size(120, 23);
            this.tbUploadRate.TabIndex = 1;
            this.tbUploadRate.UseSelectable = true;
            this.tbUploadRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUploadRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbUploadRate
            // 
            this.cmbUploadRate.FormattingEnabled = true;
            this.cmbUploadRate.ItemHeight = 23;
            this.cmbUploadRate.Location = new System.Drawing.Point(127, 23);
            this.cmbUploadRate.Name = "cmbUploadRate";
            this.cmbUploadRate.Size = new System.Drawing.Size(82, 29);
            this.cmbUploadRate.TabIndex = 2;
            this.cmbUploadRate.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 69);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Upload";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(1, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Burst (optional)";
            // 
            // tbUploadBurst
            // 
            // 
            // 
            // 
            this.tbUploadBurst.CustomButton.Image = null;
            this.tbUploadBurst.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.tbUploadBurst.CustomButton.Name = "";
            this.tbUploadBurst.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUploadBurst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUploadBurst.CustomButton.TabIndex = 1;
            this.tbUploadBurst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUploadBurst.CustomButton.UseSelectable = true;
            this.tbUploadBurst.CustomButton.Visible = false;
            this.tbUploadBurst.Enabled = false;
            this.tbUploadBurst.Lines = new string[0];
            this.tbUploadBurst.Location = new System.Drawing.Point(1, 88);
            this.tbUploadBurst.MaxLength = 32767;
            this.tbUploadBurst.Name = "tbUploadBurst";
            this.tbUploadBurst.PasswordChar = '\0';
            this.tbUploadBurst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUploadBurst.SelectedText = "";
            this.tbUploadBurst.SelectionLength = 0;
            this.tbUploadBurst.SelectionStart = 0;
            this.tbUploadBurst.ShortcutsEnabled = true;
            this.tbUploadBurst.Size = new System.Drawing.Size(120, 23);
            this.tbUploadBurst.TabIndex = 1;
            this.tbUploadBurst.UseSelectable = true;
            this.tbUploadBurst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUploadBurst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbUploadBurst
            // 
            this.cmbUploadBurst.Enabled = false;
            this.cmbUploadBurst.FormattingEnabled = true;
            this.cmbUploadBurst.ItemHeight = 23;
            this.cmbUploadBurst.Location = new System.Drawing.Point(127, 85);
            this.cmbUploadBurst.Name = "cmbUploadBurst";
            this.cmbUploadBurst.Size = new System.Drawing.Size(82, 29);
            this.cmbUploadBurst.TabIndex = 2;
            this.cmbUploadBurst.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(287, 69);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(89, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Download";
            // 
            // tglUpload
            // 
            this.tglUpload.AutoSize = true;
            this.tglUpload.Location = new System.Drawing.Point(152, 75);
            this.tglUpload.Name = "tglUpload";
            this.tglUpload.Size = new System.Drawing.Size(80, 17);
            this.tglUpload.TabIndex = 4;
            this.tglUpload.Text = "Aus";
            this.tglUpload.UseSelectable = true;
            this.tglUpload.CheckedChanged += new System.EventHandler(this.TglUpload_CheckedChanged);
            // 
            // tglDownload
            // 
            this.tglDownload.AutoSize = true;
            this.tglDownload.Location = new System.Drawing.Point(417, 75);
            this.tglDownload.Name = "tglDownload";
            this.tglDownload.Size = new System.Drawing.Size(80, 17);
            this.tglDownload.TabIndex = 4;
            this.tglDownload.Text = "Aus";
            this.tglDownload.UseSelectable = true;
            this.tglDownload.CheckedChanged += new System.EventHandler(this.TglDownload_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(2, 2);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(35, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Rate";
            // 
            // tbDownloadRate
            // 
            // 
            // 
            // 
            this.tbDownloadRate.CustomButton.Image = null;
            this.tbDownloadRate.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.tbDownloadRate.CustomButton.Name = "";
            this.tbDownloadRate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDownloadRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDownloadRate.CustomButton.TabIndex = 1;
            this.tbDownloadRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDownloadRate.CustomButton.UseSelectable = true;
            this.tbDownloadRate.CustomButton.Visible = false;
            this.tbDownloadRate.Lines = new string[0];
            this.tbDownloadRate.Location = new System.Drawing.Point(1, 26);
            this.tbDownloadRate.MaxLength = 32767;
            this.tbDownloadRate.Name = "tbDownloadRate";
            this.tbDownloadRate.PasswordChar = '\0';
            this.tbDownloadRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDownloadRate.SelectedText = "";
            this.tbDownloadRate.SelectionLength = 0;
            this.tbDownloadRate.SelectionStart = 0;
            this.tbDownloadRate.ShortcutsEnabled = true;
            this.tbDownloadRate.Size = new System.Drawing.Size(120, 23);
            this.tbDownloadRate.TabIndex = 1;
            this.tbDownloadRate.UseSelectable = true;
            this.tbDownloadRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDownloadRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(2, 64);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Burst (optional)";
            // 
            // tbDownloadBurst
            // 
            // 
            // 
            // 
            this.tbDownloadBurst.CustomButton.Image = null;
            this.tbDownloadBurst.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.tbDownloadBurst.CustomButton.Name = "";
            this.tbDownloadBurst.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDownloadBurst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDownloadBurst.CustomButton.TabIndex = 1;
            this.tbDownloadBurst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDownloadBurst.CustomButton.UseSelectable = true;
            this.tbDownloadBurst.CustomButton.Visible = false;
            this.tbDownloadBurst.Enabled = false;
            this.tbDownloadBurst.Lines = new string[0];
            this.tbDownloadBurst.Location = new System.Drawing.Point(1, 88);
            this.tbDownloadBurst.MaxLength = 32767;
            this.tbDownloadBurst.Name = "tbDownloadBurst";
            this.tbDownloadBurst.PasswordChar = '\0';
            this.tbDownloadBurst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDownloadBurst.SelectedText = "";
            this.tbDownloadBurst.SelectionLength = 0;
            this.tbDownloadBurst.SelectionStart = 0;
            this.tbDownloadBurst.ShortcutsEnabled = true;
            this.tbDownloadBurst.Size = new System.Drawing.Size(120, 23);
            this.tbDownloadBurst.TabIndex = 1;
            this.tbDownloadBurst.UseSelectable = true;
            this.tbDownloadBurst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDownloadBurst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbDownloadRate
            // 
            this.cmbDownloadRate.FormattingEnabled = true;
            this.cmbDownloadRate.ItemHeight = 23;
            this.cmbDownloadRate.Location = new System.Drawing.Point(127, 23);
            this.cmbDownloadRate.Name = "cmbDownloadRate";
            this.cmbDownloadRate.Size = new System.Drawing.Size(83, 29);
            this.cmbDownloadRate.TabIndex = 2;
            this.cmbDownloadRate.UseSelectable = true;
            // 
            // cmbDownloadBurst
            // 
            this.cmbDownloadBurst.Enabled = false;
            this.cmbDownloadBurst.FormattingEnabled = true;
            this.cmbDownloadBurst.ItemHeight = 23;
            this.cmbDownloadBurst.Location = new System.Drawing.Point(127, 85);
            this.cmbDownloadBurst.Name = "cmbDownloadBurst";
            this.cmbDownloadBurst.Size = new System.Drawing.Size(83, 29);
            this.cmbDownloadBurst.TabIndex = 2;
            this.cmbDownloadBurst.UseSelectable = true;
            // 
            // cbUploadBurst
            // 
            this.cbUploadBurst.AutoSize = true;
            this.cbUploadBurst.Location = new System.Drawing.Point(105, 66);
            this.cbUploadBurst.Name = "cbUploadBurst";
            this.cbUploadBurst.Size = new System.Drawing.Size(26, 15);
            this.cbUploadBurst.TabIndex = 5;
            this.cbUploadBurst.Text = " ";
            this.cbUploadBurst.UseSelectable = true;
            this.cbUploadBurst.CheckedChanged += new System.EventHandler(this.CbUploadBurst_CheckedChanged);
            // 
            // cbDownloadBurst
            // 
            this.cbDownloadBurst.AutoSize = true;
            this.cbDownloadBurst.Location = new System.Drawing.Point(105, 67);
            this.cbDownloadBurst.Name = "cbDownloadBurst";
            this.cbDownloadBurst.Size = new System.Drawing.Size(26, 15);
            this.cbDownloadBurst.TabIndex = 5;
            this.cbDownloadBurst.Text = " ";
            this.cbDownloadBurst.UseSelectable = true;
            this.cbDownloadBurst.CheckedChanged += new System.EventHandler(this.CbDownloadBurst_CheckedChanged);
            // 
            // btnLimit
            // 
            this.btnLimit.Highlight = true;
            this.btnLimit.Location = new System.Drawing.Point(413, 257);
            this.btnLimit.Name = "btnLimit";
            this.btnLimit.Size = new System.Drawing.Size(83, 23);
            this.btnLimit.TabIndex = 6;
            this.btnLimit.Text = "Limit";
            this.btnLimit.UseSelectable = true;
            this.btnLimit.Click += new System.EventHandler(this.BtnLimit_Click);
            // 
            // pnlUpload
            // 
            this.pnlUpload.Controls.Add(this.cmbUploadRate);
            this.pnlUpload.Controls.Add(this.cbUploadBurst);
            this.pnlUpload.Controls.Add(this.metroLabel1);
            this.pnlUpload.Controls.Add(this.tbUploadRate);
            this.pnlUpload.Controls.Add(this.metroLabel2);
            this.pnlUpload.Controls.Add(this.tbUploadBurst);
            this.pnlUpload.Controls.Add(this.cmbUploadBurst);
            this.pnlUpload.Enabled = false;
            this.pnlUpload.HorizontalScrollbarBarColor = true;
            this.pnlUpload.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlUpload.HorizontalScrollbarSize = 10;
            this.pnlUpload.Location = new System.Drawing.Point(23, 105);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(219, 147);
            this.pnlUpload.TabIndex = 7;
            this.pnlUpload.VerticalScrollbarBarColor = true;
            this.pnlUpload.VerticalScrollbarHighlightOnWheel = false;
            this.pnlUpload.VerticalScrollbarSize = 10;
            // 
            // pnlDownload
            // 
            this.pnlDownload.Controls.Add(this.tbDownloadRate);
            this.pnlDownload.Controls.Add(this.cbDownloadBurst);
            this.pnlDownload.Controls.Add(this.metroLabel5);
            this.pnlDownload.Controls.Add(this.metroLabel6);
            this.pnlDownload.Controls.Add(this.tbDownloadBurst);
            this.pnlDownload.Controls.Add(this.cmbDownloadRate);
            this.pnlDownload.Controls.Add(this.cmbDownloadBurst);
            this.pnlDownload.Enabled = false;
            this.pnlDownload.HorizontalScrollbarBarColor = true;
            this.pnlDownload.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDownload.HorizontalScrollbarSize = 10;
            this.pnlDownload.Location = new System.Drawing.Point(287, 106);
            this.pnlDownload.Name = "pnlDownload";
            this.pnlDownload.Size = new System.Drawing.Size(218, 146);
            this.pnlDownload.TabIndex = 8;
            this.pnlDownload.VerticalScrollbarBarColor = true;
            this.pnlDownload.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDownload.VerticalScrollbarSize = 10;
            // 
            // FrmLimit
            // 
            this.AcceptButton = this.btnLimit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 303);
            this.Controls.Add(this.pnlDownload);
            this.Controls.Add(this.pnlUpload);
            this.Controls.Add(this.btnLimit);
            this.Controls.Add(this.tglDownload);
            this.Controls.Add(this.tglUpload);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLimit";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Limit";
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            this.pnlDownload.ResumeLayout(false);
            this.pnlDownload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbUploadRate;
        private MetroFramework.Controls.MetroComboBox cmbUploadRate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbUploadBurst;
        private MetroFramework.Controls.MetroComboBox cmbUploadBurst;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle tglUpload;
        private MetroFramework.Controls.MetroToggle tglDownload;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbDownloadRate;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox tbDownloadBurst;
        private MetroFramework.Controls.MetroComboBox cmbDownloadRate;
        private MetroFramework.Controls.MetroComboBox cmbDownloadBurst;
        private MetroFramework.Controls.MetroCheckBox cbUploadBurst;
        private MetroFramework.Controls.MetroCheckBox cbDownloadBurst;
        private MetroFramework.Controls.MetroButton btnLimit;
        private MetroFramework.Controls.MetroPanel pnlUpload;
        private MetroFramework.Controls.MetroPanel pnlDownload;
    }
}