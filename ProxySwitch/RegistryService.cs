//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.
// Licensed under the MIT License.
// See LICENSE file in the repository root for full license information.
//

using Microsoft.Win32;
using ProxySwitch.Properties;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ProxySwitch
{
    /// <summary>
    /// Service class for accessing the registry to set the proxy server settings.
    /// </summary>
    public sealed class RegistryService
    {
        #region Static field and properties

        private static readonly Lazy<RegistryService> instance = new Lazy<RegistryService>(() => new RegistryService());

        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;

        private const string USER_ROOT = "HKEY_CURRENT_USER";

        private const string INTERNET_SETTINGS_KEY = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
        private const string INTERNET_SETTINGS_FULL_KEY = USER_ROOT + "\\" + INTERNET_SETTINGS_KEY;

        private const string PROXY_ENABLE_VALUE_NAME = "ProxyEnable";
        private const string PROXY_OVERRIDE_VALUE_NAME = "ProxyOverride";
        private const string PROXY_SERVER_VALUE_NAME = "ProxyServer";

        #endregion

        #region Properties

        /// <summary>
        /// Gets the singleton instance of the <see cref="RegistryService"/> class.
        /// </summary>
        /// <value>
        /// The singleton instance of the <see cref="RegistryService"/> class.
        /// </value>
        public static RegistryService Instance { get { return instance.Value; } }

        /// <summary>
        /// Gets a value indicating whether the proxy server is enabled or not.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the proxy server is enabled; otherwise, <c>false</c>.
        /// </value>
        public bool ProxyEnabled { get { return GetProxyServerState(); } }

        #endregion

        #region Constructors

        /// <summary>
        /// Prevents a default instance of the <see cref="RegistryService"/> class from being created.
        /// </summary>
        private RegistryService()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Enables the proxy server and overrides the proxy server settings if the option is enabled.
        /// </summary>
        public void EnableProxyServer()
        {
            if (Settings.Instance.OverrideProxySettings)
            {
                if (!string.IsNullOrWhiteSpace(Settings.Instance.ProxyServerAddress))
                {
                    string address = Settings.Instance.ProxyServerAddress +
                        (Settings.Instance.ProxyServerPort.HasValue ? $":{Settings.Instance.ProxyServerPort.Value}" : string.Empty);

                    Registry.SetValue(INTERNET_SETTINGS_FULL_KEY, PROXY_SERVER_VALUE_NAME, address);
                }

                var proxyOverride = Registry.GetValue(INTERNET_SETTINGS_FULL_KEY, PROXY_OVERRIDE_VALUE_NAME, string.Empty).ToString();

                if (Settings.Instance.BypassProxyServer)
                {
                    if (!proxyOverride.Contains("<local>"))
                    {
                        if (proxyOverride.Last() != ';')
                            proxyOverride += ";";

                        proxyOverride += "<local>";
                    }
                }
                else
                {
                    if (proxyOverride.Contains(";<local>"))
                        proxyOverride = proxyOverride.Replace(";<local>", string.Empty);
                }

                Registry.SetValue(INTERNET_SETTINGS_FULL_KEY, PROXY_OVERRIDE_VALUE_NAME, proxyOverride);
            }

            Registry.SetValue(INTERNET_SETTINGS_FULL_KEY, PROXY_ENABLE_VALUE_NAME, 1);

            RefreshInternetOptions();
        }

        /// <summary>
        /// Disables the proxy server.
        /// </summary>
        public void DisableProxyServer()
        {
            Registry.SetValue(INTERNET_SETTINGS_FULL_KEY, PROXY_ENABLE_VALUE_NAME, 0);

            RefreshInternetOptions();
        }

        /// <summary>
        /// Toggles the proxy server.
        /// </summary>
        public void ToggleProxyServer()
        {
            if (ProxyEnabled)
                DisableProxyServer();
            else
                EnableProxyServer();
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Sets an Internet option.
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa385114(v=vs.85).aspx
        /// </summary>
        /// <param name="hInternet">Handle on which to set information.</param>
        /// <param name="dwOption">Internet option to be set.</param>
        /// <param name="lpBuffer">Pointer to a buffer that contains the option setting.</param>
        /// <param name="dwBufferLength">
        /// Size of the <paramref name="lpBuffer"/> buffer.
        /// If <paramref name="lpBuffer"/> contains a string, the size is in TCHARs.
        /// If <paramref name="lpBuffer"/> contains anything other than a string, the size is in bytes.
        /// </param>
        /// <returns>Returns <c>true</c> if successful; otherwise <c>false</c>. To get a specific error message, call GetLastError.</returns>
        [DllImport("wininet.dll")]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        /// <summary>
        /// Refreshes the internet options.
        /// </summary>
        private void RefreshInternetOptions()
        {
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        /// <summary>
        /// Gets the state of the proxy server.
        /// </summary>
        /// <returns>
        ///   <c>True</c> if the proxy server is enabled; otherwise <c>false</c>.
        /// </returns>
        private bool GetProxyServerState()
        {
            return (int)Registry.GetValue(INTERNET_SETTINGS_FULL_KEY, PROXY_ENABLE_VALUE_NAME, 0) == 1;
        }

        #endregion
    }
}
