//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.  
// Licensed under the MIT License. 
// See LICENSE file in the repository root for full license information.
//

using ProxySwitch.Enums;
using ProxySwitch.EventArguments;
using ProxySwitch.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProxySwitch
{
    /// <summary>
    /// Dialog for changing the settings of the application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SettingsDialog : Form
    {
        #region Private fields

        private Timer detectChangesTimer;

        private bool settingsChanged = false;

        private string customIconOffPath = string.Empty;
        private string customIconOnPath = string.Empty;

        private Icon customIconOff;
        private Icon customIconOn;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsDialog"/> class.
        /// </summary>
        public SettingsDialog()
        {
            InitializeComponent();

            detectChangesTimer = new Timer()
            {
                Enabled = false,
                Interval = 150
            };
            detectChangesTimer.Tick += DetectChangesTimer_Tick;
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Handles the Tick event of the detectChangesTimer.
        /// Checks if the settings were changed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DetectChangesTimer_Tick(object sender, EventArgs e)
        {
            settingsChanged = DetectChanges();

            button_apply.Enabled = settingsChanged;
        }

        /// <summary>
        /// Handles the Load event of the SettingsDialog.
        /// Loads the settings.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            LoadSettings();

            detectChangesTimer.Start();
        }

        private void RadioButton_theme_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_customTheme.Checked)
            {
                pictureBox_customIconOff.Enabled = true;
                pictureBox_customIconOn.Enabled = true;
                textBox_pathIconOff.Enabled = true;
                textBox_pathIconOn.Enabled = true;
                button_openIconOff.Enabled = true;
                button_openIconOn.Enabled = true;
            }
            else
            {
                pictureBox_customIconOff.Enabled = false;
                pictureBox_customIconOn.Enabled = false;
                textBox_pathIconOff.Enabled = false;
                textBox_pathIconOn.Enabled = false;
                button_openIconOff.Enabled = false;
                button_openIconOn.Enabled = false;
            }
        }

        private void Button_openIconOn_Click(object sender, EventArgs e)
        {
            OpenIcon(true);
        }

        private void Button_openIconOff_Click(object sender, EventArgs e)
        {
            OpenIcon(false);
        }

        private void CheckBox_reverseIcons_CheckedChanged(object sender, EventArgs e)
        {
            bool reversed = checkBox_reverseIcons.Checked;

            pictureBox_defaultIconOn.Image = reversed ? Resources.networking_32 : Resources.networking_green_32;
            pictureBox_defaultIconOff.Image = reversed ? Resources.networking_green_32 : Resources.networking_32;
            pictureBox_alarmIconOn.Image = reversed ? Resources.beacon_light_32 : Resources.beacon_light_bw_32;
            pictureBox_alarmIconOff.Image = reversed ? Resources.beacon_light_bw_32 : Resources.beacon_light_32;
            pictureBox_trafficLightIconOn.Image = reversed ? Resources.traffic_lights_red_32 : Resources.traffic_lights_green_32;
            pictureBox_trafficLightIconOff.Image = reversed ? Resources.traffic_lights_green_32 : Resources.traffic_lights_red_32;

            RefreshCustomIcons();
        }

        private void RadioButton_ProxySettings_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_overrideProxySettings.Checked)
            {
                textBox_proxyAddress.Enabled = true;
                textBox_proxyPort.Enabled = true;
                checkBox_bypassProxyLocal.Enabled = true;
            }
            else
            {
                textBox_proxyAddress.Enabled = false;
                textBox_proxyPort.Enabled = false;
                checkBox_bypassProxyLocal.Enabled = false;
            }
        }

        private void TextBox_proxyPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Is Digit?
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void TextBox_proxyPort_TextPasted(object sender, ClipboardEventArgs e)
        {
            if (!int.TryParse(e.ClipboardText, out int result))
            {
                // Pasted text is not a integer number
                e.Handled = true;
            }
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {

        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            //detectChangesTimer.Stop();

            //bool cancel = false;

            //if(DetectChanges())
            //{
            //    var result = MessageBox.Show("Do you want to save un")
            //}
            //else
            //    DialogResult = DialogResult.Cancel;

            //if (!cancel)
            //    this.Close();

            //ApplySettings();

            //button_apply.Enabled = DetectChanges();
            //detectChangesTimer.Start();

            //DialogResult =
            
        }

        private void Button_apply_Click(object sender, EventArgs e)
        {
            detectChangesTimer.Stop();

            ApplySettings();

            button_apply.Enabled = DetectChanges();
            detectChangesTimer.Start();
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Loads the settings.
        /// </summary>
        private void LoadSettings()
        {
            checkBox_autostart.Checked = Settings.Instance.StartWithWindows;
            checkBox_autoDisable.Checked = Settings.Instance.DisableProxyOnStart;

            switch (Settings.Instance.Theme)
            {
                case Themes.Default:
                    radioButton_defaultTheme.Checked = true;
                    radioButton_alarmTheme.Checked = false;
                    radioButton_trafficLightTheme.Checked = false;
                    radioButton_customTheme.Checked = false;
                    break;
                case Themes.Alarm:
                    radioButton_defaultTheme.Checked = false;
                    radioButton_alarmTheme.Checked = true;
                    radioButton_trafficLightTheme.Checked = false;
                    radioButton_customTheme.Checked = false;
                    break;
                case Themes.TrafficLight:
                    radioButton_defaultTheme.Checked = false;
                    radioButton_alarmTheme.Checked = false;
                    radioButton_trafficLightTheme.Checked = true;
                    radioButton_customTheme.Checked = false;
                    break;
                case Themes.Custom:
                    radioButton_defaultTheme.Checked = false;
                    radioButton_alarmTheme.Checked = false;
                    radioButton_trafficLightTheme.Checked = false;
                    radioButton_customTheme.Checked = true;
                    break;
            }

            customIconOffPath = Settings.Instance.CustomIconProxyOff;
            customIconOnPath = Settings.Instance.CustomIconProxyOn;

            RefreshCustomIcons();

            checkBox_reverseIcons.Checked = Settings.Instance.ReverseIcons;

            if (Settings.Instance.OverrideProxySettings)
            {
                radioButton_keepProxySettings.Checked = false;
                radioButton_overrideProxySettings.Checked = true;
            }
            else
            {
                radioButton_keepProxySettings.Checked = true;
                radioButton_overrideProxySettings.Checked = false;
            }

            textBox_proxyAddress.Text = Settings.Instance.ProxyServerAddress;
            textBox_proxyPort.Text = Settings.Instance.ProxyServerPort.HasValue ? Settings.Instance.ProxyServerPort.Value.ToString() : string.Empty;
            checkBox_bypassProxyLocal.Checked = Settings.Instance.BypassProxyServer;
        }

        private void ApplySettings()
        {
            try
            {
                if (DetectChanges())
                {
                    Settings.Instance.StartWithWindows = checkBox_autostart.Checked;
                    Settings.Instance.DisableProxyOnStart = checkBox_autoDisable.Checked;

                    if (radioButton_alarmTheme.Checked)
                        Settings.Instance.Theme = Themes.Alarm;
                    else if (radioButton_trafficLightTheme.Checked)
                        Settings.Instance.Theme = Themes.TrafficLight;
                    else if (radioButton_customTheme.Checked)
                        Settings.Instance.Theme = Themes.Custom;
                    else
                        Settings.Instance.Theme = Themes.Default;

                    Settings.Instance.CopyAndSetIcon(false, customIconOffPath);
                    Settings.Instance.CopyAndSetIcon(true, customIconOnPath);

                    Settings.Instance.ReverseIcons = checkBox_reverseIcons.Checked;

                    Settings.Instance.OverrideProxySettings = radioButton_overrideProxySettings.Checked;

                    Settings.Instance.ProxyServerAddress = textBox_proxyAddress.Text;
                    Settings.Instance.ProxyServerPort = string.IsNullOrWhiteSpace(textBox_proxyPort.Text) ? default(ushort?) : Convert.ToUInt16(textBox_proxyPort.Text);
                    Settings.Instance.BypassProxyServer = checkBox_bypassProxyLocal.Checked;

                    Settings.Instance.Save();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occourd while applying the settings!\n\nError: {e.Message}",
                    "Applying settings failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Opens an icon file.
        /// </summary>
        /// <param name="iconOn">If set to <c>true</c> the icon for proxy enabled will be opened.</param>
        private void OpenIcon(bool iconOn)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = "",
                Multiselect = false
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (iconOn)
                    customIconOnPath = dlg.FileName;
                else
                    customIconOffPath = dlg.FileName;

                RefreshCustomIcons();
            }
        }

        /// <summary>
        /// Refreshes the custom icons.
        /// </summary>
        private void RefreshCustomIcons()
        {
            if (!string.IsNullOrWhiteSpace(customIconOffPath))
                customIconOff = new Icon(customIconOffPath);

            if (!string.IsNullOrWhiteSpace(customIconOnPath))
                customIconOn = new Icon(customIconOnPath);

            textBox_pathIconOff.Text = customIconOffPath?.Split('\\').Last();
            textBox_pathIconOn.Text = customIconOnPath?.Split('\\').Last();

            pictureBox_customIconOff.Image = checkBox_reverseIcons.Checked ? customIconOn?.ToBitmap() : customIconOff?.ToBitmap();
            pictureBox_customIconOn.Image = checkBox_reverseIcons.Checked ? customIconOff?.ToBitmap() : customIconOn?.ToBitmap();
        }

        /// <summary>
        /// Detects changes between the saved settings and the settings of dialog.
        /// </summary>
        /// <returns><c>True</c> if changes were detected; otherwise <c>false</c>.</returns>
        private bool DetectChanges()
        {
            bool changes = false;

            if (Settings.Instance.StartWithWindows != checkBox_autostart.Checked)
                changes = true;
            else
            {
                if (Settings.Instance.DisableProxyOnStart != checkBox_autoDisable.Checked)
                    changes = true;
                else
                {
                    switch (Settings.Instance.Theme)
                    {
                        case Themes.Default:
                            changes = !radioButton_defaultTheme.Checked;
                            break;
                        case Themes.Alarm:
                            changes = !radioButton_alarmTheme.Checked;
                            break;
                        case Themes.TrafficLight:
                            changes = !radioButton_trafficLightTheme.Checked;
                            break;
                        case Themes.Custom:
                            changes = !radioButton_customTheme.Checked;
                            break;
                    }

                    if (!changes)
                    {
                        if (string.IsNullOrWhiteSpace(Settings.Instance.CustomIconProxyOff) && string.IsNullOrWhiteSpace(customIconOffPath))
                            changes = false;
                        else if ((string.IsNullOrWhiteSpace(Settings.Instance.CustomIconProxyOff) && !string.IsNullOrWhiteSpace(customIconOffPath)) ||
                            (!string.IsNullOrWhiteSpace(Settings.Instance.CustomIconProxyOff) && string.IsNullOrWhiteSpace(customIconOffPath)))
                            changes = true;
                        else
                            changes = !Settings.Instance.CustomIconProxyOff.Split('\\').Last().Equals(customIconOffPath.Split('\\').Last());

                        if (!changes)
                        {
                            if (string.IsNullOrWhiteSpace(Settings.Instance.CustomIconProxyOn) && string.IsNullOrWhiteSpace(customIconOnPath))
                                changes = false;
                            else if ((string.IsNullOrWhiteSpace(Settings.Instance.CustomIconProxyOn) && !string.IsNullOrWhiteSpace(customIconOnPath)) ||
                                (!string.IsNullOrWhiteSpace(Settings.Instance.CustomIconProxyOn) && string.IsNullOrWhiteSpace(customIconOnPath)))
                                changes = true;
                            else
                                changes = !Settings.Instance.CustomIconProxyOn.Split('\\').Last().Equals(customIconOnPath.Split('\\').Last());

                            if (!changes)
                            {
                                if (Settings.Instance.ReverseIcons != checkBox_reverseIcons.Checked)
                                    changes = true;
                                else
                                {
                                    if (Settings.Instance.OverrideProxySettings != radioButton_overrideProxySettings.Checked)
                                        changes = true;
                                    else
                                    {
                                        if (string.IsNullOrWhiteSpace(Settings.Instance.ProxyServerAddress) && string.IsNullOrWhiteSpace(textBox_proxyAddress.Text))
                                            changes = false;
                                        else if ((string.IsNullOrWhiteSpace(Settings.Instance.ProxyServerAddress) && !string.IsNullOrWhiteSpace(textBox_proxyAddress.Text)) ||
                                            (!string.IsNullOrWhiteSpace(Settings.Instance.ProxyServerAddress) && string.IsNullOrWhiteSpace(textBox_proxyAddress.Text)))
                                            changes = true;
                                        else
                                            changes = !Settings.Instance.ProxyServerAddress.Equals(textBox_proxyAddress.Text);

                                        if (!changes)
                                        {
                                            if (!Settings.Instance.ProxyServerPort.HasValue && string.IsNullOrWhiteSpace(textBox_proxyPort.Text))
                                                changes = false;
                                            else if ((!Settings.Instance.ProxyServerPort.HasValue && !string.IsNullOrWhiteSpace(textBox_proxyPort.Text)) ||
                                                (Settings.Instance.ProxyServerPort.HasValue && string.IsNullOrWhiteSpace(textBox_proxyPort.Text)))
                                                changes = true;
                                            else
                                                changes = Settings.Instance.ProxyServerPort.Value != Convert.ToUInt16(textBox_proxyPort.Text);

                                            if (!changes)
                                                changes = Settings.Instance.BypassProxyServer != checkBox_bypassProxyLocal.Checked;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return changes;
        }

        #endregion
    }
}
