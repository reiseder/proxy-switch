namespace ProxySwitch
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.tableLayoutPanel_layout = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_proxyServer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_proxyServer = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_proxyPort = new ProxySwitch.ClipboardTextBox(this.components);
            this.label_proxyPort = new System.Windows.Forms.Label();
            this.checkBox_bypassProxyLocal = new System.Windows.Forms.CheckBox();
            this.radioButton_overrideProxySettings = new System.Windows.Forms.RadioButton();
            this.radioButton_keepProxySettings = new System.Windows.Forms.RadioButton();
            this.label_proxyAddress = new System.Windows.Forms.Label();
            this.textBox_proxyAddress = new System.Windows.Forms.TextBox();
            this.groupBox_themes = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_themes = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_reverseIcons = new System.Windows.Forms.CheckBox();
            this.radioButton_customTheme = new System.Windows.Forms.RadioButton();
            this.radioButton_alarmTheme = new System.Windows.Forms.RadioButton();
            this.radioButton_trafficLightTheme = new System.Windows.Forms.RadioButton();
            this.radioButton_defaultTheme = new System.Windows.Forms.RadioButton();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.groupBox_general = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_general = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_autoDisable = new System.Windows.Forms.CheckBox();
            this.checkBox_autostart = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel_layout.SuspendLayout();
            this.groupBox_proxyServer.SuspendLayout();
            this.tableLayoutPanel_proxyServer.SuspendLayout();
            this.groupBox_themes.SuspendLayout();
            this.tableLayoutPanel_themes.SuspendLayout();
            this.groupBox_general.SuspendLayout();
            this.tableLayoutPanel_general.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_layout
            // 
            this.tableLayoutPanel_layout.ColumnCount = 19;
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.003931F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.3999979F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099967F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.099478F));
            this.tableLayoutPanel_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.003931F));
            this.tableLayoutPanel_layout.Controls.Add(this.groupBox_proxyServer, 2, 7);
            this.tableLayoutPanel_layout.Controls.Add(this.groupBox_themes, 2, 4);
            this.tableLayoutPanel_layout.Controls.Add(this.button_ok, 9, 12);
            this.tableLayoutPanel_layout.Controls.Add(this.button_cancel, 12, 12);
            this.tableLayoutPanel_layout.Controls.Add(this.button_apply, 15, 12);
            this.tableLayoutPanel_layout.Controls.Add(this.groupBox_general, 2, 1);
            this.tableLayoutPanel_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_layout.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_layout.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_layout.Name = "tableLayoutPanel_layout";
            this.tableLayoutPanel_layout.RowCount = 14;
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.4F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.599999F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.6F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.4F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_layout.Size = new System.Drawing.Size(624, 441);
            this.tableLayoutPanel_layout.TabIndex = 5;
            // 
            // groupBox_proxyServer
            // 
            this.tableLayoutPanel_layout.SetColumnSpan(this.groupBox_proxyServer, 16);
            this.groupBox_proxyServer.Controls.Add(this.tableLayoutPanel_proxyServer);
            this.groupBox_proxyServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_proxyServer.Location = new System.Drawing.Point(11, 231);
            this.groupBox_proxyServer.Name = "groupBox_proxyServer";
            this.tableLayoutPanel_layout.SetRowSpan(this.groupBox_proxyServer, 4);
            this.groupBox_proxyServer.Size = new System.Drawing.Size(602, 142);
            this.groupBox_proxyServer.TabIndex = 5;
            this.groupBox_proxyServer.TabStop = false;
            this.groupBox_proxyServer.Text = "Proxy server";
            // 
            // tableLayoutPanel_proxyServer
            // 
            this.tableLayoutPanel_proxyServer.ColumnCount = 7;
            this.tableLayoutPanel_proxyServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel_proxyServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel_proxyServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.83F));
            this.tableLayoutPanel_proxyServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.67F));
            this.tableLayoutPanel_proxyServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.83F));
            this.tableLayoutPanel_proxyServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.83F));
            this.tableLayoutPanel_proxyServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.84F));
            this.tableLayoutPanel_proxyServer.Controls.Add(this.textBox_proxyPort, 5, 2);
            this.tableLayoutPanel_proxyServer.Controls.Add(this.label_proxyPort, 4, 2);
            this.tableLayoutPanel_proxyServer.Controls.Add(this.checkBox_bypassProxyLocal, 2, 3);
            this.tableLayoutPanel_proxyServer.Controls.Add(this.radioButton_overrideProxySettings, 1, 1);
            this.tableLayoutPanel_proxyServer.Controls.Add(this.radioButton_keepProxySettings, 1, 0);
            this.tableLayoutPanel_proxyServer.Controls.Add(this.label_proxyAddress, 2, 2);
            this.tableLayoutPanel_proxyServer.Controls.Add(this.textBox_proxyAddress, 3, 2);
            this.tableLayoutPanel_proxyServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_proxyServer.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel_proxyServer.Name = "tableLayoutPanel_proxyServer";
            this.tableLayoutPanel_proxyServer.RowCount = 5;
            this.tableLayoutPanel_proxyServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel_proxyServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel_proxyServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel_proxyServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel_proxyServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel_proxyServer.Size = new System.Drawing.Size(596, 121);
            this.tableLayoutPanel_proxyServer.TabIndex = 0;
            // 
            // textBox_proxyPort
            // 
            this.textBox_proxyPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_proxyPort.Location = new System.Drawing.Point(407, 53);
            this.textBox_proxyPort.Name = "textBox_proxyPort";
            this.textBox_proxyPort.Size = new System.Drawing.Size(88, 22);
            this.textBox_proxyPort.TabIndex = 8;
            this.textBox_proxyPort.PastedText += new ProxySwitch.ClipboardTextBox.ClipboardEventHandler(this.textBox_proxyPort_PastedText);
            this.textBox_proxyPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_proxyPort_KeyPress);
            // 
            // label_proxyPort
            // 
            this.label_proxyPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_proxyPort.Location = new System.Drawing.Point(313, 50);
            this.label_proxyPort.Name = "label_proxyPort";
            this.label_proxyPort.Size = new System.Drawing.Size(88, 25);
            this.label_proxyPort.TabIndex = 7;
            this.label_proxyPort.Text = "Port:";
            this.label_proxyPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_bypassProxyLocal
            // 
            this.tableLayoutPanel_proxyServer.SetColumnSpan(this.checkBox_bypassProxyLocal, 5);
            this.checkBox_bypassProxyLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_bypassProxyLocal.Location = new System.Drawing.Point(31, 78);
            this.checkBox_bypassProxyLocal.Name = "checkBox_bypassProxyLocal";
            this.checkBox_bypassProxyLocal.Size = new System.Drawing.Size(562, 19);
            this.checkBox_bypassProxyLocal.TabIndex = 4;
            this.checkBox_bypassProxyLocal.Text = "Bypass proxy server for local addresses";
            this.checkBox_bypassProxyLocal.UseVisualStyleBackColor = true;
            // 
            // radioButton_overrideProxySettings
            // 
            this.tableLayoutPanel_proxyServer.SetColumnSpan(this.radioButton_overrideProxySettings, 6);
            this.radioButton_overrideProxySettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_overrideProxySettings.Location = new System.Drawing.Point(17, 28);
            this.radioButton_overrideProxySettings.Name = "radioButton_overrideProxySettings";
            this.radioButton_overrideProxySettings.Size = new System.Drawing.Size(576, 19);
            this.radioButton_overrideProxySettings.TabIndex = 3;
            this.radioButton_overrideProxySettings.TabStop = true;
            this.radioButton_overrideProxySettings.Text = "Override proxy server settings";
            this.radioButton_overrideProxySettings.UseVisualStyleBackColor = true;
            // 
            // radioButton_keepProxySettings
            // 
            this.tableLayoutPanel_proxyServer.SetColumnSpan(this.radioButton_keepProxySettings, 6);
            this.radioButton_keepProxySettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_keepProxySettings.Location = new System.Drawing.Point(17, 3);
            this.radioButton_keepProxySettings.Name = "radioButton_keepProxySettings";
            this.radioButton_keepProxySettings.Size = new System.Drawing.Size(576, 19);
            this.radioButton_keepProxySettings.TabIndex = 2;
            this.radioButton_keepProxySettings.TabStop = true;
            this.radioButton_keepProxySettings.Text = "Keep proxy server settings";
            this.radioButton_keepProxySettings.UseVisualStyleBackColor = true;
            // 
            // label_proxyAddress
            // 
            this.label_proxyAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_proxyAddress.Location = new System.Drawing.Point(31, 50);
            this.label_proxyAddress.Name = "label_proxyAddress";
            this.label_proxyAddress.Size = new System.Drawing.Size(88, 25);
            this.label_proxyAddress.TabIndex = 5;
            this.label_proxyAddress.Text = "Address:";
            this.label_proxyAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_proxyAddress
            // 
            this.textBox_proxyAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_proxyAddress.Location = new System.Drawing.Point(125, 53);
            this.textBox_proxyAddress.Name = "textBox_proxyAddress";
            this.textBox_proxyAddress.Size = new System.Drawing.Size(182, 22);
            this.textBox_proxyAddress.TabIndex = 6;
            // 
            // groupBox_themes
            // 
            this.tableLayoutPanel_layout.SetColumnSpan(this.groupBox_themes, 16);
            this.groupBox_themes.Controls.Add(this.tableLayoutPanel_themes);
            this.groupBox_themes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_themes.Location = new System.Drawing.Point(11, 120);
            this.groupBox_themes.Name = "groupBox_themes";
            this.tableLayoutPanel_layout.SetRowSpan(this.groupBox_themes, 3);
            this.groupBox_themes.Size = new System.Drawing.Size(602, 105);
            this.groupBox_themes.TabIndex = 4;
            this.groupBox_themes.TabStop = false;
            this.groupBox_themes.Text = "Themes";
            // 
            // tableLayoutPanel_themes
            // 
            this.tableLayoutPanel_themes.ColumnCount = 3;
            this.tableLayoutPanel_themes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel_themes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.75F));
            this.tableLayoutPanel_themes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.75F));
            this.tableLayoutPanel_themes.Controls.Add(this.checkBox_reverseIcons, 1, 2);
            this.tableLayoutPanel_themes.Controls.Add(this.radioButton_customTheme, 2, 1);
            this.tableLayoutPanel_themes.Controls.Add(this.radioButton_alarmTheme, 1, 1);
            this.tableLayoutPanel_themes.Controls.Add(this.radioButton_trafficLightTheme, 2, 0);
            this.tableLayoutPanel_themes.Controls.Add(this.radioButton_defaultTheme, 1, 0);
            this.tableLayoutPanel_themes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_themes.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel_themes.Name = "tableLayoutPanel_themes";
            this.tableLayoutPanel_themes.RowCount = 4;
            this.tableLayoutPanel_themes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_themes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_themes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_themes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_themes.Size = new System.Drawing.Size(596, 84);
            this.tableLayoutPanel_themes.TabIndex = 0;
            // 
            // checkBox_reverseIcons
            // 
            this.checkBox_reverseIcons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_reverseIcons.Location = new System.Drawing.Point(17, 53);
            this.checkBox_reverseIcons.Name = "checkBox_reverseIcons";
            this.checkBox_reverseIcons.Size = new System.Drawing.Size(284, 19);
            this.checkBox_reverseIcons.TabIndex = 4;
            this.checkBox_reverseIcons.Text = "Reverse icons";
            this.checkBox_reverseIcons.UseVisualStyleBackColor = true;
            // 
            // radioButton_customTheme
            // 
            this.radioButton_customTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_customTheme.Location = new System.Drawing.Point(307, 28);
            this.radioButton_customTheme.Name = "radioButton_customTheme";
            this.radioButton_customTheme.Size = new System.Drawing.Size(286, 19);
            this.radioButton_customTheme.TabIndex = 3;
            this.radioButton_customTheme.TabStop = true;
            this.radioButton_customTheme.Text = "Custom";
            this.radioButton_customTheme.UseVisualStyleBackColor = true;
            // 
            // radioButton_alarmTheme
            // 
            this.radioButton_alarmTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_alarmTheme.Location = new System.Drawing.Point(17, 28);
            this.radioButton_alarmTheme.Name = "radioButton_alarmTheme";
            this.radioButton_alarmTheme.Size = new System.Drawing.Size(284, 19);
            this.radioButton_alarmTheme.TabIndex = 2;
            this.radioButton_alarmTheme.TabStop = true;
            this.radioButton_alarmTheme.Text = "Alarm";
            this.radioButton_alarmTheme.UseVisualStyleBackColor = true;
            // 
            // radioButton_trafficLightTheme
            // 
            this.radioButton_trafficLightTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_trafficLightTheme.Location = new System.Drawing.Point(307, 3);
            this.radioButton_trafficLightTheme.Name = "radioButton_trafficLightTheme";
            this.radioButton_trafficLightTheme.Size = new System.Drawing.Size(286, 19);
            this.radioButton_trafficLightTheme.TabIndex = 1;
            this.radioButton_trafficLightTheme.TabStop = true;
            this.radioButton_trafficLightTheme.Text = "Traffic light";
            this.radioButton_trafficLightTheme.UseVisualStyleBackColor = true;
            // 
            // radioButton_defaultTheme
            // 
            this.radioButton_defaultTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_defaultTheme.Location = new System.Drawing.Point(17, 3);
            this.radioButton_defaultTheme.Name = "radioButton_defaultTheme";
            this.radioButton_defaultTheme.Size = new System.Drawing.Size(284, 19);
            this.radioButton_defaultTheme.TabIndex = 0;
            this.radioButton_defaultTheme.TabStop = true;
            this.radioButton_defaultTheme.Text = "Default";
            this.radioButton_defaultTheme.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.tableLayoutPanel_layout.SetColumnSpan(this.button_ok, 3);
            this.button_ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ok.Location = new System.Drawing.Point(277, 390);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(108, 31);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.tableLayoutPanel_layout.SetColumnSpan(this.button_cancel, 3);
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_cancel.Location = new System.Drawing.Point(391, 390);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(108, 31);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_apply
            // 
            this.tableLayoutPanel_layout.SetColumnSpan(this.button_apply, 3);
            this.button_apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_apply.Location = new System.Drawing.Point(505, 390);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(108, 31);
            this.button_apply.TabIndex = 0;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            // 
            // groupBox_general
            // 
            this.tableLayoutPanel_layout.SetColumnSpan(this.groupBox_general, 16);
            this.groupBox_general.Controls.Add(this.tableLayoutPanel_general);
            this.groupBox_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_general.Location = new System.Drawing.Point(11, 9);
            this.groupBox_general.Name = "groupBox_general";
            this.tableLayoutPanel_layout.SetRowSpan(this.groupBox_general, 3);
            this.groupBox_general.Size = new System.Drawing.Size(602, 105);
            this.groupBox_general.TabIndex = 3;
            this.groupBox_general.TabStop = false;
            this.groupBox_general.Text = "General";
            // 
            // tableLayoutPanel_general
            // 
            this.tableLayoutPanel_general.ColumnCount = 2;
            this.tableLayoutPanel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.tableLayoutPanel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.5F));
            this.tableLayoutPanel_general.Controls.Add(this.checkBox_autoDisable, 1, 1);
            this.tableLayoutPanel_general.Controls.Add(this.checkBox_autostart, 1, 0);
            this.tableLayoutPanel_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_general.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel_general.Name = "tableLayoutPanel_general";
            this.tableLayoutPanel_general.RowCount = 3;
            this.tableLayoutPanel_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_general.Size = new System.Drawing.Size(596, 84);
            this.tableLayoutPanel_general.TabIndex = 0;
            // 
            // checkBox_autoDisable
            // 
            this.checkBox_autoDisable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_autoDisable.Location = new System.Drawing.Point(17, 28);
            this.checkBox_autoDisable.Name = "checkBox_autoDisable";
            this.checkBox_autoDisable.Size = new System.Drawing.Size(576, 19);
            this.checkBox_autoDisable.TabIndex = 1;
            this.checkBox_autoDisable.Text = "Disable proxy server on start up";
            this.checkBox_autoDisable.UseVisualStyleBackColor = true;
            // 
            // checkBox_autostart
            // 
            this.checkBox_autostart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_autostart.Location = new System.Drawing.Point(17, 3);
            this.checkBox_autostart.Name = "checkBox_autostart";
            this.checkBox_autostart.Size = new System.Drawing.Size(576, 19);
            this.checkBox_autostart.TabIndex = 0;
            this.checkBox_autostart.Text = "Start application with Windows";
            this.checkBox_autostart.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel_layout);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.tableLayoutPanel_layout.ResumeLayout(false);
            this.groupBox_proxyServer.ResumeLayout(false);
            this.tableLayoutPanel_proxyServer.ResumeLayout(false);
            this.tableLayoutPanel_proxyServer.PerformLayout();
            this.groupBox_themes.ResumeLayout(false);
            this.tableLayoutPanel_themes.ResumeLayout(false);
            this.groupBox_general.ResumeLayout(false);
            this.tableLayoutPanel_general.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_layout;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.GroupBox groupBox_general;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_general;
        private System.Windows.Forms.CheckBox checkBox_autoDisable;
        private System.Windows.Forms.CheckBox checkBox_autostart;
        private System.Windows.Forms.GroupBox groupBox_themes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_themes;
        private System.Windows.Forms.CheckBox checkBox_reverseIcons;
        private System.Windows.Forms.RadioButton radioButton_customTheme;
        private System.Windows.Forms.RadioButton radioButton_alarmTheme;
        private System.Windows.Forms.RadioButton radioButton_trafficLightTheme;
        private System.Windows.Forms.RadioButton radioButton_defaultTheme;
        private System.Windows.Forms.GroupBox groupBox_proxyServer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_proxyServer;
        private System.Windows.Forms.Label label_proxyPort;
        private System.Windows.Forms.CheckBox checkBox_bypassProxyLocal;
        private System.Windows.Forms.RadioButton radioButton_overrideProxySettings;
        private System.Windows.Forms.RadioButton radioButton_keepProxySettings;
        private System.Windows.Forms.Label label_proxyAddress;
        private System.Windows.Forms.TextBox textBox_proxyAddress;
        private ProxySwitch.ClipboardTextBox textBox_proxyPort;
    }
}