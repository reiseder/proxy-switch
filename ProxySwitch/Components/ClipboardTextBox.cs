//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.  
// Licensed under the MIT License. 
// See LICENSE file in the repository root for full license information.
//

//
// Source code inspired by this article on Visual C# Kicks
// http://www.vcskicks.com/clipboard-textbox.php
//

using ProxySwitch.EventArguments;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProxySwitch.Components
{
    /// <summary>
    /// TextBox control that provides events for clipboard actions.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TextBox" />
    public partial class ClipboardTextBox : TextBox
    {
        #region Static fields and constants

        private const int WIN_MSG_ID_CUT = 0x0300;
        private const int WIN_MSG_ID_COPY = 0x0301;
        private const int WIN_MSG_ID_PASTE = 0x0302;

        #endregion

        #region Delegates and events

        /// <summary>
        /// Occurs when the text of the control was cut.
        /// </summary>
        [Category("Clipboard")]
        public event EventHandler<ClipboardEventArgs> TextCut;
        /// <summary>
        /// Raises the <see cref="E:TextCut" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ClipboardEventArgs"/> instance containing the event data.</param>
        protected virtual void OnTextCut(ClipboardEventArgs e)
        {
            TextCut?.Invoke(this, e);
        }

        /// <summary>
        /// Occurs when the text of the control was copied.
        /// </summary>
        [Category("Clipboard")]
        public event EventHandler<ClipboardEventArgs> TextCopied;
        /// <summary>
        /// Raises the <see cref="E:TextCopied" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ClipboardEventArgs"/> instance containing the event data.</param>
        protected virtual void OnTextCopied(ClipboardEventArgs e)
        {
            TextCopied?.Invoke(this, e);
        }

        /// <summary>
        /// Occurs when text was pasted to the control.
        /// </summary>
        [Category("Clipboard")]
        public event EventHandler<ClipboardEventArgs> TextPasted;
        /// <summary>
        /// Raises the <see cref="E:TextPasted" /> event.
        /// </summary>
        /// <param name="e">The <see cref="ClipboardEventArgs"/> instance containing the event data.</param>
        protected virtual void OnTextPasted(ClipboardEventArgs e)
        {
            TextPasted?.Invoke(this, e);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipboardTextBox"/> class.
        /// </summary>
        public ClipboardTextBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipboardTextBox"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public ClipboardTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Processes Windows messages.
        /// </summary>
        /// <param name="m">A Windows Message object.</param>
        protected override void WndProc(ref Message m)
        {
            bool handled = false;

            switch (m.Msg)
            {
                case WIN_MSG_ID_CUT:
                    handled = InvokeEvent(OnTextCut, SelectedText);
                    break;
                case WIN_MSG_ID_COPY:
                    handled = InvokeEvent(OnTextCopied, SelectedText);
                    break;
                case WIN_MSG_ID_PASTE:
                    handled = InvokeEvent(OnTextPasted, Clipboard.GetText());
                    break;
            }

            if (!handled)
                base.WndProc(ref m);
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Invokes the specified clipboard event.
        /// </summary>
        /// <param name="eventMethod">The event method.</param>
        /// <param name="clipboardText">The clipboard text.</param>
        /// <returns><c>True</c> if the event was handled; otherwise <c>false</c>.</returns>
        private bool InvokeEvent(Action<ClipboardEventArgs> eventMethod, string clipboardText)
        {
            ClipboardEventArgs e = new ClipboardEventArgs(clipboardText);

            eventMethod(e);

            return e.Handled;
        }

        #endregion
    }
}
