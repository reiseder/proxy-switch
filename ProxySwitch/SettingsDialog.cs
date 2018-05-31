using ProxySwitch.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProxySwitch
{
    /// <summary>
    /// Dialog for displaying information about the application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SettingsDialog : Form
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsDialog"/> class.
        /// </summary>
        public SettingsDialog()
        {
            InitializeComponent();
        }

        #endregion

        #region Event handlers

        private void TextBox_proxyPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Is Digit?
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        #endregion

        private void textBox_proxyPort_PastedText(object sender, ClipboardEventArgs e)
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

        }

        private void Button_apply_Click(object sender, EventArgs e)
        {

        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton_customTheme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton_overrideProxySettings_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button_openIconOn_Click(object sender, EventArgs e)
        {

        }

        private void Button_openIconOff_Click(object sender, EventArgs e)
        {

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

            // TODO: Check if custom icons exist

            pictureBox_customIconOn.Image = null;
            pictureBox_customIconOff.Image = null;
        }
    }
}
