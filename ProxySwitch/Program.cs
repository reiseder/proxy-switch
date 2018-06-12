//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.  
// Licensed under the MIT License. 
// See LICENSE file in the repository root for full license information.
//

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
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
            var guidAttributes = Assembly.GetEntryAssembly().GetCustomAttributes(typeof(GuidAttribute), false);
            var assemblyGuid = guidAttributes.Length > 0 ? ((GuidAttribute)guidAttributes[0]).Value : string.Empty;

            mutex = new Mutex(true, $"Local\\{assemblyGuid}", out bool createdNew);

            if (createdNew)
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new TrayApplicationContext());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Unexpected error occurred while executing Proxy Switch!\n\nMessage: { e.Message}\n\nStackTrace: { e.StackTrace}",
                        "Unexpected error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }

            mutex.Dispose();
        }
    }
}
