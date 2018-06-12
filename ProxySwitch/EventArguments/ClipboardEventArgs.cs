//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.  
// Licensed under the MIT License. 
// See LICENSE file in the repository root for full license information.
//

//
// Source code inspired by this article on Visual C# Kicks
// http://www.vcskicks.com/clipboard-textbox.php
//

using System;

namespace ProxySwitch.EventArguments
{
    /// <summary>
    /// Event arguments for handling clipboard events. 
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class ClipboardEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the clipboard text.
        /// </summary>
        /// <value>
        /// The clipboard text.
        /// </value>
        public string ClipboardText { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ClipboardEventArgs"/> is handled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if handled; otherwise, <c>false</c>.
        /// </value>
        public bool Handled { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipboardEventArgs" /> class.
        /// </summary>
        /// <param name="clipboardText">The clipboard text.</param>
        public ClipboardEventArgs(string clipboardText)
        {
            ClipboardText = clipboardText;
            Handled = false;
        }
    }
}
