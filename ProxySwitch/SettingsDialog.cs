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
            if(!int.TryParse(e.ClipboardText, out int result))
            {
                // Pasted text is not a integer number
                e.Handled = true;
            }
        }
    }
}
