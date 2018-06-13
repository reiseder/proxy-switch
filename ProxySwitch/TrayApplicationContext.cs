//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.  
// Licensed under the MIT License. 
// See LICENSE file in the repository root for full license information.
//

using Microsoft.Win32;
using ProxySwitch.Controls;
using ProxySwitch.Properties;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
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

        private Timer refreshIconTimer;

        #endregion

        #region Constructors

        public TrayApplicationContext()
        {
            InitializeComponent();

            aboutDialog = new AboutDialog();
            settingsDialog = new SettingsDialog();

            UpdateIcon();
            CreateRefreshIconTimer();
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
            if (settingsDialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void AboutItem_Click(object sender, EventArgs e)
        {
            aboutDialog.ShowDialog();
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            ExitThread();
        }

        private void RefreshIconTimer_Tick(object sender, EventArgs e)
        {
            UpdateIcon();
        }

        #endregion

        #region Methods

        protected override void ExitThreadCore()
        {
            refreshIconTimer.Stop();
            notifyIcon.Visible = false;

            base.ExitThreadCore();
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Creates and starts the refreshIconTimer.
        /// </summary>
        private void CreateRefreshIconTimer()
        {
            refreshIconTimer = new Timer();
            refreshIconTimer.Interval = Settings.Instance.RefreshInterval * 1000;
            refreshIconTimer.Tick += RefreshIconTimer_Tick;
            refreshIconTimer.Start();
        }

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
                notifyIcon.Icon = Resources.networking_green;
            else
                notifyIcon.Icon = Resources.networking;
        }

        #endregion
    }
}
