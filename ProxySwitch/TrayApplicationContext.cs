//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.  
// Licensed under the MIT License. 
// See LICENSE file in the repository root for full license information.
//

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProxySwitch
{
    internal partial class TrayApplicationContext : ApplicationContext
    {
        #region Static fields and constants

        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;

        private const string USER_ROOT = "HKEY_CURRENT_USER";
        private const string INTERNET_SETTINGS_KEY = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
        private const string INTERNET_SETTINGS_FULL_KEY = USER_ROOT + "\\" + INTERNET_SETTINGS_KEY;
        private const string PROXY_ENABLE_VALUE_NAME = "ProxyEnable";

        #endregion

        #region Private fields

        private AboutDialog aboutDialog;
        private SettingsDialog settingsDialog;

        #endregion

        #region Constructors

        public TrayApplicationContext()
        {
            InitializeComponent();

            aboutDialog = new AboutDialog();
            settingsDialog = new SettingsDialog();

            UpdateIcon();

            timer_refreshProxyState.Start();
        }

        #endregion

        #region Event handler

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ToggleProxy();
            UpdateIcon();
        }

        private void NotifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(notifyIcon, null);
            }
        }

        private void SettingsItem_Click(object sender, EventArgs e)
        {
            settingsDialog.ShowDialog();
        }

        private void AboutItem_Click(object sender, EventArgs e)
        {
            aboutDialog.ShowDialog();
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            ExitThread();
        }

        private void Timer_refreshProxyState_Tick(object sender, EventArgs e)
        {
            UpdateIcon();
        }

        #endregion

        #region Methods

        protected override void ExitThreadCore()
        {
            timer_refreshProxyState.Stop();
            notifyIcon.Visible = false;
            base.ExitThreadCore();
        }

        #endregion

        #region Helper methods

        private bool ReadProxyState()
        {
            return (int)Registry.GetValue(INTERNET_SETTINGS_FULL_KEY, PROXY_ENABLE_VALUE_NAME, 0) == 1;
        }

        private void ToggleProxy()
        {
            Registry.SetValue(INTERNET_SETTINGS_FULL_KEY, PROXY_ENABLE_VALUE_NAME, ReadProxyState() ? 0 : 1);

            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);

        }

        private void UpdateIcon()
        {
            if (ReadProxyState())
                notifyIcon.Icon = Properties.Resources.networking_green;
            else
                notifyIcon.Icon = Properties.Resources.networking;
        }

        #endregion
    }
}
