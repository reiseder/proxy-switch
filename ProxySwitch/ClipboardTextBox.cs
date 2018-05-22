using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitch
{
    public partial class ClipboardTextBox : TextBox
    {
        private const int WM_CUT = 0x0300;
        private const int WM_COPY = 0x0301;
        private const int WM_PASTE = 0x0302;

        public delegate void ClipboardEventHandler(object sender, ClipboardEventArgs e);

        [Category("Clipboard")]
        public event ClipboardEventHandler CutText;
        [Category("Clipboard")]
        public event ClipboardEventHandler CopiedText;
        [Category("Clipboard")]
        public event ClipboardEventHandler PastedText;

        public ClipboardTextBox()
        {
            InitializeComponent();
        }

        public ClipboardTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            ClipboardEventArgs e = new ClipboardEventArgs();

            if (m.Msg == WM_CUT)
            {
                e.SetClipboardText(this.SelectedText);
                CutText?.Invoke(this, e);
            }
            else if (m.Msg == WM_COPY)
            {
                e.SetClipboardText(this.SelectedText);
                CopiedText?.Invoke(this,e);
            }
            else if (m.Msg == WM_PASTE)
            {
                e.SetClipboardText(Clipboard.GetText());
                PastedText?.Invoke(this, e);
            }

            if (!e.Handled)
            {
                base.WndProc(ref m);
            }
        }
    }

    public class ClipboardEventArgs : EventArgs
    {
        public string ClipboardText { get; private set; }
        public bool Handled { get; set; }

        public ClipboardEventArgs()
        {
            Handled = false;
        }

        internal void SetClipboardText(string clipboardText)
        {
            ClipboardText = clipboardText;
        }
    }
}
