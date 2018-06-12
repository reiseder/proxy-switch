//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.  
// Licensed under the MIT License. 
// See LICENSE file in the repository root for full license information.
//

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProxySwitch.Controls
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
            label_versionCopyright.Text = $"Version {Application.ProductVersion}\n" +
                $"Copyright © {DateTime.Now.Year} Matthias Reiseder.\nAll rights reserved.";
        }

        /// <summary>
        /// Handles the LinkClicked event of a RichTextBox control.
        /// Opens the default browser with the URL of the link.
        /// Updates
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
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
