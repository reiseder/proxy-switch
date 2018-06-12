//
// Copyright (c) 2018 Matthias Reiseder. All rights reserved.  
// Licensed under the MIT License. 
// See LICENSE file in the repository root for full license information.
//

using ProxySwitch.Enums;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ProxySwitch.Properties
{
    /// <summary>
    /// Class for saving the proxy server settings.
    /// </summary>
    public sealed class Settings
    {
        #region Static field an properties

        private static readonly Lazy<Settings> instance = new Lazy<Settings>(() => new Settings(true));

        private static readonly string DIR = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ProxySwitch\";
        private static readonly string ICON_DIR = DIR + @"Icons\";
        private static readonly string PATH = DIR + @"Settings.xml";

        #endregion

        #region Private fields

        private Icon customProxyOff;
        private Icon customProxyOn;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the singleton instance of the <see cref="Settings"/> class.
        /// </summary>
        /// <value>
        /// The singleton instance of the <see cref="Settings"/> class.
        /// </value>
        public static Settings Instance { get { return instance.Value; } }

        /// <summary>
        /// Gets or sets a value indicating whether Proxy Switch will start with Windows or not.
        /// </summary>
        /// <value>
        ///   <c>True</c> if Proxy Switch starts with Windows; otherwise, <c>false</c>.
        /// </value>
        public bool StartWithWindows { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Proxy Switch will disable the proxy server on start up.
        /// </summary>
        /// <value>
        ///   <c>True</c> if Proxy Switch will disable the proxy server on start up; otherwise, <c>false</c>.
        /// </value>
        public bool DisableProxyOnStart { get; set; }

        /// <summary>
        /// Gets or sets the Proxy Switch theme.
        /// </summary>
        /// <value>
        /// The Proxy Switch theme.
        /// </value>
        public Themes Theme { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Proxy Switch will reverse the icons or not.
        /// </summary>
        /// <value>
        ///   <c>True</c> if Proxy Switch will reverse the icons; otherwise, <c>false</c>.
        /// </value>
        public bool ReverseIcons { get; set; }

        /// <summary>
        /// Gets or sets the path of the custom icon if proxy server is on.
        /// </summary>
        /// <value>
        /// The path of the custom icon if proxy server is on.
        /// </value>
        public string CustomIconProxyOn { get; set; }

        /// <summary>
        /// Gets the custom icon if proxy server is on.
        /// </summary>
        /// <value>
        /// The custom icon if proxy server is on.
        /// </value>
        public Icon CustomProxyOn { get { return customProxyOn; } }

        /// <summary>
        /// Gets or sets the path of the custom icon if proxy server is off.
        /// </summary>
        /// <value>
        /// The path of the custom icon if proxy server is off.
        /// </value>
        public string CustomIconProxyOff { get; set; }

        /// <summary>
        /// Gets the custom icon if proxy server is off.
        /// </summary>
        /// <value>
        /// The custom icon if proxy server is off.
        /// </value>
        public Icon CustomProxyOff { get { return customProxyOff; } }

        /// <summary>
        /// Gets or sets a value indicating whether Proxy Switch will override the settings when enabling the proxy server or not.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [override proxy settings]; otherwise, <c>false</c>.
        /// </value>
        public bool OverrideProxySettings { get; set; }

        /// <summary>
        /// Gets or sets the proxy server address.
        /// </summary>
        /// <value>
        /// The proxy server address.
        /// </value>
        public string ProxyServerAddress { get; set; }

        /// <summary>
        /// Gets or sets the proxy server port.
        /// </summary>
        /// <value>
        /// The proxy server port.
        /// </value>
        public ushort? ProxyServerPort { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the proxy server will bypass local networks or not.
        /// </summary>
        /// <value>
        ///   <c>True</c> if the proxy server will bypass local networks; otherwise, <c>false</c>.
        /// </value>
        public bool BypassProxyServer { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Prevents a default instance of the <see cref="Settings"/> class from being created.
        /// </summary>
        private Settings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings"/> class.
        /// </summary>
        /// <param name="load">if set to <c>true</c> [load].</param>
        private Settings(bool load)
        {
            if (load)
                Load();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Saves the settings to file.
        /// </summary>
        /// <returns><c>True</c> if successful; otherwise <c>false</c>.</returns>
        public bool Save()
        {
            bool result = false;

            if (!Directory.Exists(DIR))
                Directory.CreateDirectory(DIR);

            using (FileStream fs = new FileStream(PATH, FileMode.Create))
            {
                new XmlSerializer(GetType()).Serialize(fs, this);
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Copies the icon of the custom theme and sets the corresponding setting.
        /// </summary>
        /// <param name="iconOn">If set to <c>true</c> the icon will be copied to the on setting; otherwise the icon will be copied to the off setting.</param>
        /// <param name="iconPath">The path of the icon.</param>
        /// <returns><c>True</c> if successful; otherwise <c>false</c>.</returns>
        public bool CopyAndSetIcon(bool iconOn, string iconPath)
        {
            bool result = false;

            try
            {
                if (File.Exists(iconPath))
                {
                    if (!Directory.Exists(ICON_DIR))
                        Directory.CreateDirectory(ICON_DIR);

                    if (iconOn)
                    {
                        CustomIconProxyOn = ICON_DIR + iconPath.Split('\\').Last();
                        File.Copy(iconPath, CustomIconProxyOff, true);
                        customProxyOn = new Icon(CustomIconProxyOn);
                    }
                    else
                    {
                        CustomIconProxyOff = ICON_DIR + iconPath.Split('\\').Last();
                        File.Copy(iconPath, CustomIconProxyOn, true);
                        customProxyOff = new Icon(CustomIconProxyOff);
                    }

                    result = true;
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Loads the settings from file.
        /// </summary>
        private void Load()
        {
            try
            {
                if (File.Exists(PATH) ? true : Save())
                {
                    using (FileStream fs = new FileStream(PATH, FileMode.Open))
                    {
                        var settings = new XmlSerializer(GetType()).Deserialize((fs)) as Settings;

                        BypassProxyServer = settings.BypassProxyServer;
                        CustomIconProxyOff = settings.CustomIconProxyOff;
                        CustomIconProxyOn = settings.CustomIconProxyOn;
                        DisableProxyOnStart = settings.DisableProxyOnStart;
                        OverrideProxySettings = settings.OverrideProxySettings;
                        ProxyServerAddress = settings.ProxyServerAddress;
                        ProxyServerPort = settings.ProxyServerPort;
                        ReverseIcons = settings.ReverseIcons;
                        StartWithWindows = settings.StartWithWindows;
                        Theme = settings.Theme;

                        if (!string.IsNullOrWhiteSpace(CustomIconProxyOff))
                        {
                            try
                            {
                                customProxyOff = new Icon(CustomIconProxyOff);
                            }
                            catch
                            {
                                // Error while setting custom icon for proxy server off state, set it to null
                                customProxyOff = null;
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(CustomIconProxyOn))
                        {
                            try
                            {
                                customProxyOn = new Icon(CustomIconProxyOn);
                            }
                            catch
                            {
                                // Error while setting custom icon for proxy server on state, set it to null
                                customProxyOn = null;
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }

        #endregion
    }
}
