//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.
// Licensed under the MIT License.
// See LICENSE file in the repository root for full license information.
//

using ProxySwitch.Controls;
using ProxySwitch.Properties;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace ProxySwitch
{
    internal sealed partial class TrayApplicationContext : ApplicationContext
    {
        #region Private fields

        private AboutDialog aboutDialog;
        private SettingsDialog settingsDialog;

        private Timer refreshIconTimer;

        private bool userState;

        #endregion

        #region Constructors

        public TrayApplicationContext()
        {
            InitializeComponent();

            Settings.Instance.SettingsChanged += Settings_SettingsChanged;

            aboutDialog = new AboutDialog();
            settingsDialog = new SettingsDialog();

            if (Settings.Instance.DisableProxyOnStart)
                RegistryService.Instance.DisableProxyServer();

            userState = RegistryService.Instance.ProxyEnabled;

            UpdateIcon();
            CreateRefreshIconTimer();
        }

        #endregion

        #region Event handler

        private void Settings_SettingsChanged(object sender, EventArgs e)
        {
            refreshIconTimer.Interval = Settings.Instance.RefreshInterval * 1000;
            UpdateIcon();
        }

        private void RefreshIconTimer_Tick(object sender, EventArgs e)
        {
            if (Settings.Instance.KeepProxyServerState && userState != RegistryService.Instance.ProxyEnabled)
            {
                if (userState)
                    RegistryService.Instance.EnableProxyServer();
                else
                    RegistryService.Instance.DisableProxyServer();
            }

            UpdateIcon();
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            RegistryService.Instance.ToggleProxyServer();
            userState = RegistryService.Instance.ProxyEnabled;
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
            if (!settingsDialog.Visible)
                settingsDialog.ShowDialog();
        }

        private void AboutItem_Click(object sender, EventArgs e)
        {
            if (!aboutDialog.Visible)
                aboutDialog.ShowDialog();
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            ExitThread();
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
            refreshIconTimer = new Timer
            {
                Enabled = false,
                Interval = Settings.Instance.RefreshInterval * 1000
            };

            refreshIconTimer.Tick += RefreshIconTimer_Tick;
            refreshIconTimer.Start();
        }

        private void UpdateIcon()
        {
            bool useOnIcon = RegistryService.Instance.ProxyEnabled != Settings.Instance.ReverseIcons;

            switch (Settings.Instance.Theme)
            {
                case Enums.Theme.Alarm:
                    notifyIcon.Icon = useOnIcon ? Resources.beacon_light_bw : Resources.beacon_light;
                    break;
                case Enums.Theme.TrafficLight:
                    notifyIcon.Icon = useOnIcon ? Resources.traffic_lights_green : Resources.traffic_lights_red;
                    break;
                case Enums.Theme.Custom:
                    if (Settings.Instance.CustomProxyOff != null && Settings.Instance.CustomProxyOn != null)
                        notifyIcon.Icon = useOnIcon ? Settings.Instance.CustomProxyOn : Settings.Instance.CustomProxyOff;
                    else
                        notifyIcon.Icon = useOnIcon ? Resources.networking_green : Resources.networking;
                    break;
                case Enums.Theme.Default:
                default:
                    notifyIcon.Icon = useOnIcon ? Resources.networking_green : Resources.networking;
                    break;
            }
        }

        #endregion
    }
}
