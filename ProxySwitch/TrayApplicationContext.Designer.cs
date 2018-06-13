using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProxySwitch
{
    internal partial class TrayApplicationContext
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            // 
            // notifyIcon
            //
            this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            this.notifyIcon.ContextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyIcon.ContextMenuStrip.Items.Add("&Settings", Properties.Resources.wrench_16, SettingsItem_Click);
            this.notifyIcon.ContextMenuStrip.Items.Add("&About", Properties.Resources.information_16, AboutItem_Click);
            this.notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            this.notifyIcon.ContextMenuStrip.Items.Add("&Exit", null, ExitItem_Click);
            this.notifyIcon.Icon = Properties.Resources.proxySwitch;
            this.notifyIcon.Text = "Proxy Switch";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
            this.notifyIcon.MouseUp += NotifyIcon_MouseUp;
        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}
