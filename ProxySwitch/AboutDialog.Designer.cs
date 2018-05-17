namespace ProxySwitch
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.tabControl_licenses = new System.Windows.Forms.TabControl();
            this.tabPage_license = new System.Windows.Forms.TabPage();
            this.richTextBox_license = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox_credits = new System.Windows.Forms.RichTextBox();
            this.button_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.tabControl_licenses.SuspendLayout();
            this.tabPage_license.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Image = global::ProxySwitch.Properties.Resources.proxySwitch_32;
            this.pictureBox_icon.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_icon.TabIndex = 0;
            this.pictureBox_icon.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(50, 12);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(163, 32);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Proxy Switch";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_version
            // 
            this.label_version.Location = new System.Drawing.Point(12, 47);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(200, 20);
            this.label_version.TabIndex = 2;
            this.label_version.Text = "Version 0.0.0.0";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_copyright
            // 
            this.label_copyright.Location = new System.Drawing.Point(13, 67);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(200, 40);
            this.label_copyright.TabIndex = 3;
            this.label_copyright.Text = "Copyright © 2018 Matthias Reiseder.\r\nAll rights reserved.";
            this.label_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl_licenses
            // 
            this.tabControl_licenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_licenses.Controls.Add(this.tabPage_license);
            this.tabControl_licenses.Controls.Add(this.tabPage2);
            this.tabControl_licenses.Location = new System.Drawing.Point(12, 110);
            this.tabControl_licenses.Name = "tabControl_licenses";
            this.tabControl_licenses.SelectedIndex = 0;
            this.tabControl_licenses.Size = new System.Drawing.Size(600, 289);
            this.tabControl_licenses.TabIndex = 4;
            // 
            // tabPage_license
            // 
            this.tabPage_license.Controls.Add(this.richTextBox_license);
            this.tabPage_license.Location = new System.Drawing.Point(4, 22);
            this.tabPage_license.Name = "tabPage_license";
            this.tabPage_license.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_license.Size = new System.Drawing.Size(592, 263);
            this.tabPage_license.TabIndex = 0;
            this.tabPage_license.Text = "License";
            this.tabPage_license.UseVisualStyleBackColor = true;
            // 
            // richTextBox_license
            // 
            this.richTextBox_license.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_license.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_license.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_license.Name = "richTextBox_license";
            this.richTextBox_license.ReadOnly = true;
            this.richTextBox_license.Size = new System.Drawing.Size(586, 257);
            this.richTextBox_license.TabIndex = 0;
            this.richTextBox_license.Text = resources.GetString("richTextBox_license.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox_credits);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Credits";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox_credits
            // 
            this.richTextBox_credits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_credits.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_credits.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_credits.Name = "richTextBox_credits";
            this.richTextBox_credits.ReadOnly = true;
            this.richTextBox_credits.Size = new System.Drawing.Size(586, 257);
            this.richTextBox_credits.TabIndex = 0;
            this.richTextBox_credits.Text = "Icon set:\n\n\"Farm-Fresh Web Icons\" by FatCow Web Hosting - CC BY 3.0\nWebsite: http" +
    "://www.fatcow.com/free-icons\n";
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.Location = new System.Drawing.Point(512, 405);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 25);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.tabControl_licenses);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pictureBox_icon);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Proxy Switch";
            this.Load += new System.EventHandler(this.AboutDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.tabControl_licenses.ResumeLayout(false);
            this.tabPage_license.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.TabControl tabControl_licenses;
        private System.Windows.Forms.TabPage tabPage_license;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.RichTextBox richTextBox_license;
        private System.Windows.Forms.RichTextBox richTextBox_credits;
    }
}