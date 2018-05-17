using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProxySwitch
{
    /// <summary>
    /// Dialog for displaying information about the application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AboutDialog : Form
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutDialog"/> class.
        /// </summary>
        public AboutDialog()
        {
            InitializeComponent();
        }

        #endregion

        #region Event handler

        /// <summary>
        /// Handles the Load event of the AboutDialog form.
        /// Updates version and copyright information.
        /// Updates
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AboutDialog_Load(object sender, EventArgs e)
        {
            label_version.Text = $"Version {Application.ProductVersion}";
            label_copyright.Text = $"Copyright © {DateTime.Now.Year} Matthias Reiseder.\nAll rights reserved.";
        }

        /// <summary>
        /// Handles the Click event of the button_ok control.
        /// Closes the dialog.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
