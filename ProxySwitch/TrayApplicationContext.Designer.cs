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
            this.timer_refreshProxyState = new System.Windows.Forms.Timer(this.components);
            // 
            // notifyIcon
            //
            this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            this.notifyIcon.ContextMenuStrip.Items.Add("&Exit", null, ExitItem_Click);
            this.notifyIcon.Icon = Properties.Resources.globe_network;
            this.notifyIcon.Text = "ProxySwitch";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
            this.notifyIcon.MouseUp += NotifyIcon_MouseUp;
            //
            // timer_refreshProxyState
            //
            this.timer_refreshProxyState.Enabled = false;
            this.timer_refreshProxyState.Interval = 30000;
            this.timer_refreshProxyState.Tick += Timer_refreshProxyState_Tick;
        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer_refreshProxyState;
    }
}
