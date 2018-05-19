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
            this.label_versionCopyright = new System.Windows.Forms.Label();
            this.tabControl_licenses = new System.Windows.Forms.TabControl();
            this.tabPage_license = new System.Windows.Forms.TabPage();
            this.richTextBox_license = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox_credits = new System.Windows.Forms.RichTextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.tableLayoutPanel_layout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.tabControl_licenses.SuspendLayout();
            this.tabPage_license.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel_layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_icon.Image = global::ProxySwitch.Properties.Resources.proxySwitch_32;
            this.pictureBox_icon.Location = new System.Drawing.Point(9, 9);
            this.pictureBox_icon.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_icon.TabIndex = 0;
            this.pictureBox_icon.TabStop = false;
            // 
            // label_title
            // 
            this.tableLayoutPanel_layout.SetColumnSpan(this.label_title, 16);
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(47, 6);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(566, 37);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Proxy Switch";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_versionCopyright
            // 
            this.tableLayoutPanel_layout.SetColumnSpan(this.label_versionCopyright, 17);
            this.label_versionCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_versionCopyright.Location = new System.Drawing.Point(9, 43);
            this.label_versionCopyright.Name = "label_versionCopyright";
            this.tableLayoutPanel_layout.SetRowSpan(this.label_versionCopyright, 2);
            this.label_versionCopyright.Size = new System.Drawing.Size(604, 74);
            this.label_versionCopyright.TabIndex = 2;
            this.label_versionCopyright.Text = "Version 0.0.0.0\r\nCopyright © 2018 Matthias Reiseder.\r\nAll rights reserved.";
            this.label_versionCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl_licenses
            // 
            this.tableLayoutPanel_layout.SetColumnSpan(this.tabControl_licenses, 17);
            this.tabControl_licenses.Controls.Add(this.tabPage_license);
            this.tabControl_licenses.Controls.Add(this.tabPage2);
            this.tabControl_licenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_licenses.Location = new System.Drawing.Point(9, 120);
            this.tabControl_licenses.Name = "tabControl_licenses";
            this.tableLayoutPanel_layout.SetRowSpan(this.tabControl_licenses, 8);
            this.tabControl_licenses.SelectedIndex = 0;
            this.tabControl_licenses.Size = new System.Drawing.Size(604, 264);
            this.tabControl_licenses.TabIndex = 4;
            // 
            // tabPage_license
            // 
            this.tabPage_license.Controls.Add(this.richTextBox_license);
            this.tabPage_license.Location = new System.Drawing.Point(4, 22);
            this.tabPage_license.Name = "tabPage_license";
            this.tabPage_license.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_license.Size = new System.Drawing.Size(596, 238);
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
            this.richTextBox_license.Size = new System.Drawing.Size(590, 232);
            this.richTextBox_license.TabIndex = 0;
            this.richTextBox_license.Text = resources.GetString("richTextBox_license.Text");
            this.richTextBox_license.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBox_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox_credits);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 238);
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
            this.richTextBox_credits.Size = new System.Drawing.Size(590, 232);
            this.richTextBox_credits.TabIndex = 0;
            this.richTextBox_credits.Text = "Icon set:\n\n\"Farm-Fresh Web Icons\" by FatCow Web Hosting - CC BY 3.0\nWebsite: http" +
    "://www.fatcow.com/free-icons\n";
            this.richTextBox_credits.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBox_LinkClicked);
            // 
            // button_ok
            // 
            this.tableLayoutPanel_layout.SetColumnSpan(this.button_ok, 3);
            this.button_ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ok.Location = new System.Drawing.Point(505, 390);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(108, 31);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // tableLayoutPanel_layout
            // 
            this.tableLayoutPanel_layout.ColumnCount = 19;
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.003936F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.3999679F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.09951F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.003936F));
            this.tableLayoutPanel_layout.Controls.Add(this.tabControl_licenses, 1, 4);
            this.tableLayoutPanel_layout.Controls.Add(this.pictureBox_icon, 1, 1);
            this.tableLayoutPanel_layout.Controls.Add(this.button_ok, 15, 12);
            this.tableLayoutPanel_layout.Controls.Add(this.label_title, 2, 1);
            this.tableLayoutPanel_layout.Controls.Add(this.label_versionCopyright, 1, 2);
            this.tableLayoutPanel_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_layout.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_layout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_layout.Name = "tableLayoutPanel_layout";
            this.tableLayoutPanel_layout.RowCount = 14;
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.4F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.4F));
            this.tableLayoutPanel_layout.Size = new System.Drawing.Size(624, 441);
            this.tableLayoutPanel_layout.TabIndex = 5;
            // 
            // AboutDialog
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel_layout);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Proxy Switch";
            this.Load += new System.EventHandler(this.AboutDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.tabControl_licenses.ResumeLayout(false);
            this.tabPage_license.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel_layout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_versionCopyright;
        private System.Windows.Forms.TabControl tabControl_licenses;
        private System.Windows.Forms.TabPage tabPage_license;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.RichTextBox richTextBox_license;
        private System.Windows.Forms.RichTextBox richTextBox_credits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_layout;
    }
}