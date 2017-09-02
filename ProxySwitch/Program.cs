using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitch
{
    static class Program
    {
        private static Mutex mutex;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            mutex = new Mutex(true, $"Local\\{GetAssemblyGuid()}", out bool createdNew);

            if (createdNew)
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    TrayApplicationContext context = new TrayApplicationContext();
                    Application.Run(context);
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Unexpected error occurred while executing the application!\n\nMessage: { e.Message}\n\nStackTrace: { e.StackTrace}",
                        "Unexpected error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mutex.ReleaseMutex();
                    mutex.Dispose();
                }
            }
        }

        #region Helper methods

        private static string GetAssemblyGuid()
        {
            var attributes = Assembly.GetEntryAssembly().GetCustomAttributes(typeof(GuidAttribute), false);

            if (attributes.Length > 0)
                return ((GuidAttribute)attributes[0]).Value;
            else
                return string.Empty;
        }

        #endregion
    }
}
