//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.
// Licensed under the MIT License.
// See LICENSE file in the repository root for full license information.
//

using ClipboardTextBox;
using ProxySwitch.Enums;
using ProxySwitch.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProxySwitch.Controls
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

        /// <summary>
        /// Handles the FormClosing event of the SettingsDialog.
        /// Checks if there unsaved changes and saves the settings if the user wants.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void SettingsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            detectChangesTimer.Stop();

            bool applySettings = false;
            bool cancel = false;

            if (DialogResult == DialogResult.OK)
            {
                applySettings = DetectChanges();
                cancel = false;
            }
            else if (DialogResult == DialogResult.Cancel && e.CloseReason == CloseReason.None)
            {
                applySettings = false;
                cancel = false;
            }
            else
            {
                if (DetectChanges())
                {
                    var result = MessageBox.Show("Unsaved changes will be lost!\n\nDo you want to save the settings?", "Unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    switch (result)
                    {
                        case DialogResult.Cancel:
                            applySettings = false;
                            cancel = true;
                            break;
                        case DialogResult.Yes:
                            applySettings = true;
                            cancel = false;
                            break;
                        case DialogResult.No:
                            applySettings = false;
                            cancel = false;
                            break;
                    }
                }
            }

            if (!cancel && applySettings)
            {
                if (ApplySettings())
                    DialogResult = DialogResult.OK;
                else
                    cancel = true;
            }

            if (cancel)
                detectChangesTimer.Start();

            e.Cancel = cancel;
        }

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
        /// Handles the CheckedChanged event of the them RadioButton controls.
        /// Enables or disables the custom theme setting controls.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the Button_openIconOn control.
        /// Opens the custom icon file for the proxy enabled icon.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Button_openIconOn_Click(object sender, EventArgs e)
        {
            OpenIcon(true);
        }

        /// <summary>
        /// Handles the Click event of the Button_openIconOff control.
        /// Opens the custom icon file for the proxy disabled icon.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Button_openIconOff_Click(object sender, EventArgs e)
        {
            OpenIcon(false);
        }

        /// <summary>
        /// Handles the CheckedChanged event of the CheckBox_reverseIcons control.
        /// Updates the preview icons.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the CheckedChanged event of the proxy server setting RadioButton controls.
        /// Enables or disables the proxy server setting controls.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the KeyPress event of the ClipboardTextBox controls.
        /// Prevents the input of non digit characters.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void ClipboardTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Is Digit?
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        /// <summary>
        /// Handles the TextPasted event of the ClipboardTextBox controls.
        /// Prevents the pasting of text that cannot be converted to a number.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ClipboardEventArgs"/> instance containing the event data.</param>
        private void ClipboardTextBox_TextPasted(object sender, ClipboardEventArgs e)
        {
            if (!int.TryParse(e.ClipboardText, out int result))
            {
                // Pasted text is not a integer number
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the Button_ok control.
        /// Sets the DialogResult to OK and closes the dialog.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Button_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the Button_apply control.
        /// Applies the settings.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
            checkBox_autoDisable.Checked = Settings.Instance.DisableProxyOnStart;

            textBox_refreshInterval.Text = Settings.Instance.RefreshInterval.ToString();

            switch (Settings.Instance.Theme)
            {
                case Theme.Default:
                    radioButton_defaultTheme.Checked = true;
                    radioButton_alarmTheme.Checked = false;
                    radioButton_trafficLightTheme.Checked = false;
                    radioButton_customTheme.Checked = false;
                    break;
                case Theme.Alarm:
                    radioButton_defaultTheme.Checked = false;
                    radioButton_alarmTheme.Checked = true;
                    radioButton_trafficLightTheme.Checked = false;
                    radioButton_customTheme.Checked = false;
                    break;
                case Theme.TrafficLight:
                    radioButton_defaultTheme.Checked = false;
                    radioButton_alarmTheme.Checked = false;
                    radioButton_trafficLightTheme.Checked = true;
                    radioButton_customTheme.Checked = false;
                    break;
                case Theme.Custom:
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

        /// <summary>
        /// Applies the settings.
        /// </summary>
        /// <returns><c>True</c> is successful; otherwise <c>false</c>.</returns>
        private bool ApplySettings()
        {
            bool result = false;

            try
            {
                if (DetectChanges())
                {
                    Settings.Instance.DisableProxyOnStart = checkBox_autoDisable.Checked;

                    if (string.IsNullOrWhiteSpace(textBox_refreshInterval.Text) || Convert.ToInt32(textBox_refreshInterval.Text) < 1)
                    {
                        MessageBox.Show("The refresh interval must not be empty or less than 1!",
                            "Refresh interval", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return false;
                    }

                    Settings.Instance.RefreshInterval = string.IsNullOrWhiteSpace(textBox_refreshInterval.Text) ?
                        30 : Convert.ToInt32(textBox_refreshInterval.Text);

                    if (radioButton_alarmTheme.Checked)
                        Settings.Instance.Theme = Theme.Alarm;
                    else if (radioButton_trafficLightTheme.Checked)
                        Settings.Instance.Theme = Theme.TrafficLight;
                    else if (radioButton_customTheme.Checked)
                        Settings.Instance.Theme = Theme.Custom;
                    else
                        Settings.Instance.Theme = Theme.Default;

                    if (Settings.Instance.Theme == Theme.Custom)
                    {
                        if (!Settings.Instance.CheckIconFile(customIconOffPath) || !Settings.Instance.CheckIconFile(customIconOffPath))
                        {
                            MessageBox.Show("The two custom icon files must be set if the custom theme is selected!",
                                "Icon file", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return false;
                        }
                    }

                    Settings.Instance.CopyAndSetIcon(false, customIconOffPath);
                    Settings.Instance.CopyAndSetIcon(true, customIconOnPath);

                    Settings.Instance.ReverseIcons = checkBox_reverseIcons.Checked;

                    Settings.Instance.OverrideProxySettings = radioButton_overrideProxySettings.Checked;

                    Settings.Instance.ProxyServerAddress = textBox_proxyAddress.Text;
                    Settings.Instance.ProxyServerPort = string.IsNullOrWhiteSpace(textBox_proxyPort.Text) ? default(ushort?) : Convert.ToUInt16(textBox_proxyPort.Text);
                    Settings.Instance.BypassProxyServer = checkBox_bypassProxyLocal.Checked;

                    result = Settings.Instance.Save();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occourd while applying the settings!\n\nError: {e.Message}",
                    "Applying settings failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                result = false;
            }

            return result;
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
                Filter = "Icon files (*.ico)|*.ico",
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
        /// Detects changes between the saved settings and the dialog.
        /// </summary>
        /// <returns><c>True</c> if changes were detected; otherwise <c>false</c>.</returns>
        private bool DetectChanges()
        {
            bool changes = false;

            if (Settings.Instance.DisableProxyOnStart != checkBox_autoDisable.Checked)
                changes = true;
            else
            {
                if (string.IsNullOrEmpty(textBox_refreshInterval.Text) || Settings.Instance.RefreshInterval != Convert.ToInt32(textBox_refreshInterval.Text))
                {
                    changes = true;
                }
                else
                {
                    switch (Settings.Instance.Theme)
                    {
                        case Theme.Default:
                            changes = !radioButton_defaultTheme.Checked;
                            break;
                        case Theme.Alarm:
                            changes = !radioButton_alarmTheme.Checked;
                            break;
                        case Theme.TrafficLight:
                            changes = !radioButton_trafficLightTheme.Checked;
                            break;
                        case Theme.Custom:
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
