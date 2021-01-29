namespace PlenBotLogUploader
{
    partial class FormMain
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
            if (!disposing || components == null)
            {
            }
            else
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTwitchSettings = new System.Windows.Forms.GroupBox();
            this.buttonTwitchCommands = new System.Windows.Forms.Button();
            this.checkBoxTwitchOnlySuccess = new System.Windows.Forms.CheckBox();
            this.buttonDisConnectTwitch = new System.Windows.Forms.Button();
            this.buttonCustomName = new System.Windows.Forms.Button();
            this.buttonChangeTwitchChannel = new System.Windows.Forms.Button();
            this.checkBoxPostToTwitch = new System.Windows.Forms.CheckBox();
            this.buttonReconnectBot = new System.Windows.Forms.Button();
            this.buttonBossData = new System.Windows.Forms.Button();
            this.checkBoxFileSizeIgnore = new System.Windows.Forms.CheckBox();
            this.checkBoxUploadLogs = new System.Windows.Forms.CheckBox();
            this.groupBoxArcdpsLogs = new System.Windows.Forms.GroupBox();
            this.buttonCopyApplicationSession = new System.Windows.Forms.Button();
            this.buttonSession = new System.Windows.Forms.Button();
            this.buttonOpenLogs = new System.Windows.Forms.Button();
            this.buttonDPSReportServer = new System.Windows.Forms.Button();
            this.labelLocationInfo = new System.Windows.Forms.Label();
            this.buttonLogsLocation = new System.Windows.Forms.Button();
            this.checkBoxTrayMinimiseToIcon = new System.Windows.Forms.CheckBox();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUploadLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPostToTwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorFirst = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOpenDPSReportServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenCustomName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenTwitchCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenArcVersionsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorSecond = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemDiscordWebhooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenPingSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorThird = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOtherSettings = new System.Windows.Forms.GroupBox();
            this.buttonAleevaSettings = new System.Windows.Forms.Button();
            this.buttonGW2API = new System.Windows.Forms.Button();
            this.comboBoxMaxUploads = new System.Windows.Forms.ComboBox();
            this.labelMaximumUploads = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBoxStartWhenWindowsStarts = new System.Windows.Forms.CheckBox();
            this.buttonDiscordWebhooks = new System.Windows.Forms.Button();
            this.buttonArcVersionChecking = new System.Windows.Forms.Button();
            this.buttonPingSettings = new System.Windows.Forms.Button();
            this.buttonUpdateNow = new System.Windows.Forms.Button();
            this.timerCheckUpdate = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBoxMainConsole = new System.Windows.Forms.RichTextBox();
            this.groupBoxTwitchSettings.SuspendLayout();
            this.groupBoxArcdpsLogs.SuspendLayout();
            this.contextMenuStripIcon.SuspendLayout();
            this.groupBoxOtherSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTwitchSettings
            // 
            resources.ApplyResources(this.groupBoxTwitchSettings, "groupBoxTwitchSettings");
            this.groupBoxTwitchSettings.Controls.Add(this.buttonTwitchCommands);
            this.groupBoxTwitchSettings.Controls.Add(this.checkBoxTwitchOnlySuccess);
            this.groupBoxTwitchSettings.Controls.Add(this.buttonDisConnectTwitch);
            this.groupBoxTwitchSettings.Controls.Add(this.buttonCustomName);
            this.groupBoxTwitchSettings.Controls.Add(this.buttonChangeTwitchChannel);
            this.groupBoxTwitchSettings.Controls.Add(this.checkBoxPostToTwitch);
            this.groupBoxTwitchSettings.Controls.Add(this.buttonReconnectBot);
            this.groupBoxTwitchSettings.Name = "groupBoxTwitchSettings";
            this.groupBoxTwitchSettings.TabStop = false;
            this.toolTip.SetToolTip(this.groupBoxTwitchSettings, resources.GetString("groupBoxTwitchSettings.ToolTip"));
            // 
            // buttonTwitchCommands
            // 
            resources.ApplyResources(this.buttonTwitchCommands, "buttonTwitchCommands");
            this.buttonTwitchCommands.Name = "buttonTwitchCommands";
            this.toolTip.SetToolTip(this.buttonTwitchCommands, resources.GetString("buttonTwitchCommands.ToolTip"));
            this.buttonTwitchCommands.UseVisualStyleBackColor = true;
            this.buttonTwitchCommands.Click += new System.EventHandler(this.ButtonTwitchCommands_Click);
            // 
            // checkBoxTwitchOnlySuccess
            // 
            resources.ApplyResources(this.checkBoxTwitchOnlySuccess, "checkBoxTwitchOnlySuccess");
            this.checkBoxTwitchOnlySuccess.Name = "checkBoxTwitchOnlySuccess";
            this.toolTip.SetToolTip(this.checkBoxTwitchOnlySuccess, resources.GetString("checkBoxTwitchOnlySuccess.ToolTip"));
            this.checkBoxTwitchOnlySuccess.UseVisualStyleBackColor = true;
            // 
            // buttonDisConnectTwitch
            // 
            resources.ApplyResources(this.buttonDisConnectTwitch, "buttonDisConnectTwitch");
            this.buttonDisConnectTwitch.Name = "buttonDisConnectTwitch";
            this.toolTip.SetToolTip(this.buttonDisConnectTwitch, resources.GetString("buttonDisConnectTwitch.ToolTip"));
            this.buttonDisConnectTwitch.UseVisualStyleBackColor = true;
            this.buttonDisConnectTwitch.Click += new System.EventHandler(this.ButtonDisConnectTwitch_Click);
            // 
            // buttonCustomName
            // 
            resources.ApplyResources(this.buttonCustomName, "buttonCustomName");
            this.buttonCustomName.Name = "buttonCustomName";
            this.toolTip.SetToolTip(this.buttonCustomName, resources.GetString("buttonCustomName.ToolTip"));
            this.buttonCustomName.UseVisualStyleBackColor = true;
            this.buttonCustomName.Click += new System.EventHandler(this.ButtonCustomName_Click);
            // 
            // buttonChangeTwitchChannel
            // 
            resources.ApplyResources(this.buttonChangeTwitchChannel, "buttonChangeTwitchChannel");
            this.buttonChangeTwitchChannel.Name = "buttonChangeTwitchChannel";
            this.toolTip.SetToolTip(this.buttonChangeTwitchChannel, resources.GetString("buttonChangeTwitchChannel.ToolTip"));
            this.buttonChangeTwitchChannel.UseVisualStyleBackColor = true;
            this.buttonChangeTwitchChannel.Click += new System.EventHandler(this.ButtonChangeTwitchChannel_Click);
            // 
            // checkBoxPostToTwitch
            // 
            resources.ApplyResources(this.checkBoxPostToTwitch, "checkBoxPostToTwitch");
            this.checkBoxPostToTwitch.Name = "checkBoxPostToTwitch";
            this.toolTip.SetToolTip(this.checkBoxPostToTwitch, resources.GetString("checkBoxPostToTwitch.ToolTip"));
            this.checkBoxPostToTwitch.UseVisualStyleBackColor = true;
            // 
            // buttonReconnectBot
            // 
            resources.ApplyResources(this.buttonReconnectBot, "buttonReconnectBot");
            this.buttonReconnectBot.Name = "buttonReconnectBot";
            this.toolTip.SetToolTip(this.buttonReconnectBot, resources.GetString("buttonReconnectBot.ToolTip"));
            this.buttonReconnectBot.UseVisualStyleBackColor = true;
            this.buttonReconnectBot.Click += new System.EventHandler(this.ButtonReconnectBot_Click);
            // 
            // buttonBossData
            // 
            resources.ApplyResources(this.buttonBossData, "buttonBossData");
            this.buttonBossData.Name = "buttonBossData";
            this.toolTip.SetToolTip(this.buttonBossData, resources.GetString("buttonBossData.ToolTip"));
            this.buttonBossData.UseVisualStyleBackColor = true;
            this.buttonBossData.Click += new System.EventHandler(this.ButtonBossData_Click);
            // 
            // checkBoxFileSizeIgnore
            // 
            resources.ApplyResources(this.checkBoxFileSizeIgnore, "checkBoxFileSizeIgnore");
            this.checkBoxFileSizeIgnore.Name = "checkBoxFileSizeIgnore";
            this.toolTip.SetToolTip(this.checkBoxFileSizeIgnore, resources.GetString("checkBoxFileSizeIgnore.ToolTip"));
            this.checkBoxFileSizeIgnore.UseVisualStyleBackColor = true;
            this.checkBoxFileSizeIgnore.CheckedChanged += new System.EventHandler(this.checkBoxFileSizeIgnore_CheckedChanged_1);
            // 
            // checkBoxUploadLogs
            // 
            resources.ApplyResources(this.checkBoxUploadLogs, "checkBoxUploadLogs");
            this.checkBoxUploadLogs.Name = "checkBoxUploadLogs";
            this.toolTip.SetToolTip(this.checkBoxUploadLogs, resources.GetString("checkBoxUploadLogs.ToolTip"));
            this.checkBoxUploadLogs.UseVisualStyleBackColor = true;
            // 
            // groupBoxArcdpsLogs
            // 
            resources.ApplyResources(this.groupBoxArcdpsLogs, "groupBoxArcdpsLogs");
            this.groupBoxArcdpsLogs.Controls.Add(this.buttonCopyApplicationSession);
            this.groupBoxArcdpsLogs.Controls.Add(this.buttonSession);
            this.groupBoxArcdpsLogs.Controls.Add(this.buttonBossData);
            this.groupBoxArcdpsLogs.Controls.Add(this.buttonOpenLogs);
            this.groupBoxArcdpsLogs.Controls.Add(this.buttonDPSReportServer);
            this.groupBoxArcdpsLogs.Controls.Add(this.checkBoxFileSizeIgnore);
            this.groupBoxArcdpsLogs.Controls.Add(this.labelLocationInfo);
            this.groupBoxArcdpsLogs.Controls.Add(this.buttonLogsLocation);
            this.groupBoxArcdpsLogs.Controls.Add(this.checkBoxUploadLogs);
            this.groupBoxArcdpsLogs.Name = "groupBoxArcdpsLogs";
            this.groupBoxArcdpsLogs.TabStop = false;
            this.toolTip.SetToolTip(this.groupBoxArcdpsLogs, resources.GetString("groupBoxArcdpsLogs.ToolTip"));
            // 
            // buttonCopyApplicationSession
            // 
            resources.ApplyResources(this.buttonCopyApplicationSession, "buttonCopyApplicationSession");
            this.buttonCopyApplicationSession.Name = "buttonCopyApplicationSession";
            this.toolTip.SetToolTip(this.buttonCopyApplicationSession, resources.GetString("buttonCopyApplicationSession.ToolTip"));
            this.buttonCopyApplicationSession.UseVisualStyleBackColor = true;
            this.buttonCopyApplicationSession.Click += new System.EventHandler(this.ButtonCopyApplicationSession_Click);
            // 
            // buttonSession
            // 
            resources.ApplyResources(this.buttonSession, "buttonSession");
            this.buttonSession.Name = "buttonSession";
            this.toolTip.SetToolTip(this.buttonSession, resources.GetString("buttonSession.ToolTip"));
            this.buttonSession.UseVisualStyleBackColor = true;
            this.buttonSession.Click += new System.EventHandler(this.ButtonSession_Click);
            // 
            // buttonOpenLogs
            // 
            resources.ApplyResources(this.buttonOpenLogs, "buttonOpenLogs");
            this.buttonOpenLogs.Name = "buttonOpenLogs";
            this.toolTip.SetToolTip(this.buttonOpenLogs, resources.GetString("buttonOpenLogs.ToolTip"));
            this.buttonOpenLogs.UseVisualStyleBackColor = true;
            this.buttonOpenLogs.Click += new System.EventHandler(this.ButtonOpenLogs_Click);
            // 
            // buttonDPSReportServer
            // 
            resources.ApplyResources(this.buttonDPSReportServer, "buttonDPSReportServer");
            this.buttonDPSReportServer.Name = "buttonDPSReportServer";
            this.toolTip.SetToolTip(this.buttonDPSReportServer, resources.GetString("buttonDPSReportServer.ToolTip"));
            this.buttonDPSReportServer.UseVisualStyleBackColor = true;
            this.buttonDPSReportServer.Click += new System.EventHandler(this.ButtonDPSReportServer_Click);
            // 
            // labelLocationInfo
            // 
            resources.ApplyResources(this.labelLocationInfo, "labelLocationInfo");
            this.labelLocationInfo.Name = "labelLocationInfo";
            this.toolTip.SetToolTip(this.labelLocationInfo, resources.GetString("labelLocationInfo.ToolTip"));
            // 
            // buttonLogsLocation
            // 
            resources.ApplyResources(this.buttonLogsLocation, "buttonLogsLocation");
            this.buttonLogsLocation.Name = "buttonLogsLocation";
            this.toolTip.SetToolTip(this.buttonLogsLocation, resources.GetString("buttonLogsLocation.ToolTip"));
            this.buttonLogsLocation.UseVisualStyleBackColor = true;
            this.buttonLogsLocation.Click += new System.EventHandler(this.ButtonLogsLocation_Click);
            // 
            // checkBoxTrayMinimiseToIcon
            // 
            resources.ApplyResources(this.checkBoxTrayMinimiseToIcon, "checkBoxTrayMinimiseToIcon");
            this.checkBoxTrayMinimiseToIcon.Name = "checkBoxTrayMinimiseToIcon";
            this.toolTip.SetToolTip(this.checkBoxTrayMinimiseToIcon, resources.GetString("checkBoxTrayMinimiseToIcon.ToolTip"));
            this.checkBoxTrayMinimiseToIcon.UseVisualStyleBackColor = true;
            // 
            // notifyIconTray
            // 
            resources.ApplyResources(this.notifyIconTray, "notifyIconTray");
            this.notifyIconTray.ContextMenuStrip = this.contextMenuStripIcon;
            this.notifyIconTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconTray_MouseDoubleClick);
            // 
            // contextMenuStripIcon
            // 
            resources.ApplyResources(this.contextMenuStripIcon, "contextMenuStripIcon");
            this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUploadLogs,
            this.toolStripMenuItemPostToTwitch,
            this.toolStripSeparatorFirst,
            this.toolStripMenuItemOpenDPSReportServer,
            this.toolStripMenuItemOpenCustomName,
            this.toolStripMenuItemOpenTwitchCommands,
            this.toolStripMenuItemOpenArcVersionsSettings,
            this.toolStripSeparatorSecond,
            this.toolStripMenuItemDiscordWebhooks,
            this.toolStripMenuItemOpenPingSettings,
            this.toolStripSeparatorThird,
            this.toolStripMenuItemExit});
            this.contextMenuStripIcon.Name = "contextMenuStripIcon";
            this.toolTip.SetToolTip(this.contextMenuStripIcon, resources.GetString("contextMenuStripIcon.ToolTip"));
            // 
            // toolStripMenuItemUploadLogs
            // 
            resources.ApplyResources(this.toolStripMenuItemUploadLogs, "toolStripMenuItemUploadLogs");
            this.toolStripMenuItemUploadLogs.CheckOnClick = true;
            this.toolStripMenuItemUploadLogs.Name = "toolStripMenuItemUploadLogs";
            this.toolStripMenuItemUploadLogs.CheckedChanged += new System.EventHandler(this.ToolStripMenuItemUploadLogs_CheckedChanged);
            // 
            // toolStripMenuItemPostToTwitch
            // 
            resources.ApplyResources(this.toolStripMenuItemPostToTwitch, "toolStripMenuItemPostToTwitch");
            this.toolStripMenuItemPostToTwitch.CheckOnClick = true;
            this.toolStripMenuItemPostToTwitch.Name = "toolStripMenuItemPostToTwitch";
            this.toolStripMenuItemPostToTwitch.CheckedChanged += new System.EventHandler(this.ToolStripMenuItemPostToTwitch_CheckedChanged);
            // 
            // toolStripSeparatorFirst
            // 
            resources.ApplyResources(this.toolStripSeparatorFirst, "toolStripSeparatorFirst");
            this.toolStripSeparatorFirst.Name = "toolStripSeparatorFirst";
            // 
            // toolStripMenuItemOpenDPSReportServer
            // 
            resources.ApplyResources(this.toolStripMenuItemOpenDPSReportServer, "toolStripMenuItemOpenDPSReportServer");
            this.toolStripMenuItemOpenDPSReportServer.Name = "toolStripMenuItemOpenDPSReportServer";
            this.toolStripMenuItemOpenDPSReportServer.Click += new System.EventHandler(this.ToolStripMenuItemOpenDPSReportServer_Click);
            // 
            // toolStripMenuItemOpenCustomName
            // 
            resources.ApplyResources(this.toolStripMenuItemOpenCustomName, "toolStripMenuItemOpenCustomName");
            this.toolStripMenuItemOpenCustomName.Name = "toolStripMenuItemOpenCustomName";
            this.toolStripMenuItemOpenCustomName.Click += new System.EventHandler(this.ToolStripMenuItemOpenCustomName_Click);
            // 
            // toolStripMenuItemOpenTwitchCommands
            // 
            resources.ApplyResources(this.toolStripMenuItemOpenTwitchCommands, "toolStripMenuItemOpenTwitchCommands");
            this.toolStripMenuItemOpenTwitchCommands.Name = "toolStripMenuItemOpenTwitchCommands";
            this.toolStripMenuItemOpenTwitchCommands.Click += new System.EventHandler(this.ToolStripMenuItemOpenTwitchCommands_Click);
            // 
            // toolStripMenuItemOpenArcVersionsSettings
            // 
            resources.ApplyResources(this.toolStripMenuItemOpenArcVersionsSettings, "toolStripMenuItemOpenArcVersionsSettings");
            this.toolStripMenuItemOpenArcVersionsSettings.Name = "toolStripMenuItemOpenArcVersionsSettings";
            this.toolStripMenuItemOpenArcVersionsSettings.Click += new System.EventHandler(this.ToolStripMenuItemOpenArcVersionsSettings_Click);
            // 
            // toolStripSeparatorSecond
            // 
            resources.ApplyResources(this.toolStripSeparatorSecond, "toolStripSeparatorSecond");
            this.toolStripSeparatorSecond.Name = "toolStripSeparatorSecond";
            // 
            // toolStripMenuItemDiscordWebhooks
            // 
            resources.ApplyResources(this.toolStripMenuItemDiscordWebhooks, "toolStripMenuItemDiscordWebhooks");
            this.toolStripMenuItemDiscordWebhooks.Name = "toolStripMenuItemDiscordWebhooks";
            this.toolStripMenuItemDiscordWebhooks.Click += new System.EventHandler(this.ToolStripMenuItemDiscordWebhooks_Click);
            // 
            // toolStripMenuItemOpenPingSettings
            // 
            resources.ApplyResources(this.toolStripMenuItemOpenPingSettings, "toolStripMenuItemOpenPingSettings");
            this.toolStripMenuItemOpenPingSettings.Name = "toolStripMenuItemOpenPingSettings";
            this.toolStripMenuItemOpenPingSettings.Click += new System.EventHandler(this.ToolStripMenuItemOpenPingSettings_Click);
            // 
            // toolStripSeparatorThird
            // 
            resources.ApplyResources(this.toolStripSeparatorThird, "toolStripSeparatorThird");
            this.toolStripSeparatorThird.Name = "toolStripSeparatorThird";
            // 
            // toolStripMenuItemExit
            // 
            resources.ApplyResources(this.toolStripMenuItemExit, "toolStripMenuItemExit");
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // groupBoxOtherSettings
            // 
            resources.ApplyResources(this.groupBoxOtherSettings, "groupBoxOtherSettings");
            this.groupBoxOtherSettings.Controls.Add(this.buttonAleevaSettings);
            this.groupBoxOtherSettings.Controls.Add(this.buttonGW2API);
            this.groupBoxOtherSettings.Controls.Add(this.comboBoxMaxUploads);
            this.groupBoxOtherSettings.Controls.Add(this.labelMaximumUploads);
            this.groupBoxOtherSettings.Controls.Add(this.buttonReset);
            this.groupBoxOtherSettings.Controls.Add(this.checkBoxStartWhenWindowsStarts);
            this.groupBoxOtherSettings.Controls.Add(this.buttonDiscordWebhooks);
            this.groupBoxOtherSettings.Controls.Add(this.buttonArcVersionChecking);
            this.groupBoxOtherSettings.Controls.Add(this.checkBoxTrayMinimiseToIcon);
            this.groupBoxOtherSettings.Controls.Add(this.buttonPingSettings);
            this.groupBoxOtherSettings.Name = "groupBoxOtherSettings";
            this.groupBoxOtherSettings.TabStop = false;
            this.toolTip.SetToolTip(this.groupBoxOtherSettings, resources.GetString("groupBoxOtherSettings.ToolTip"));
            // 
            // buttonAleevaSettings
            // 
            resources.ApplyResources(this.buttonAleevaSettings, "buttonAleevaSettings");
            this.buttonAleevaSettings.Image = global::PlenBotLogUploader.Properties.Resources.aleeva_icon16;
            this.buttonAleevaSettings.Name = "buttonAleevaSettings";
            this.toolTip.SetToolTip(this.buttonAleevaSettings, resources.GetString("buttonAleevaSettings.ToolTip"));
            this.buttonAleevaSettings.UseVisualStyleBackColor = true;
            this.buttonAleevaSettings.Click += new System.EventHandler(this.ButtonAleevaSettings_Click);
            // 
            // buttonGW2API
            // 
            resources.ApplyResources(this.buttonGW2API, "buttonGW2API");
            this.buttonGW2API.Name = "buttonGW2API";
            this.toolTip.SetToolTip(this.buttonGW2API, resources.GetString("buttonGW2API.ToolTip"));
            this.buttonGW2API.UseVisualStyleBackColor = true;
            this.buttonGW2API.Click += new System.EventHandler(this.ButtonGW2API_Click);
            // 
            // comboBoxMaxUploads
            // 
            resources.ApplyResources(this.comboBoxMaxUploads, "comboBoxMaxUploads");
            this.comboBoxMaxUploads.FormattingEnabled = true;
            this.comboBoxMaxUploads.Items.AddRange(new object[] {
            resources.GetString("comboBoxMaxUploads.Items"),
            resources.GetString("comboBoxMaxUploads.Items1"),
            resources.GetString("comboBoxMaxUploads.Items2"),
            resources.GetString("comboBoxMaxUploads.Items3"),
            resources.GetString("comboBoxMaxUploads.Items4"),
            resources.GetString("comboBoxMaxUploads.Items5"),
            resources.GetString("comboBoxMaxUploads.Items6"),
            resources.GetString("comboBoxMaxUploads.Items7"),
            resources.GetString("comboBoxMaxUploads.Items8"),
            resources.GetString("comboBoxMaxUploads.Items9")});
            this.comboBoxMaxUploads.Name = "comboBoxMaxUploads";
            this.toolTip.SetToolTip(this.comboBoxMaxUploads, resources.GetString("comboBoxMaxUploads.ToolTip"));
            // 
            // labelMaximumUploads
            // 
            resources.ApplyResources(this.labelMaximumUploads, "labelMaximumUploads");
            this.labelMaximumUploads.Name = "labelMaximumUploads";
            this.toolTip.SetToolTip(this.labelMaximumUploads, resources.GetString("labelMaximumUploads.ToolTip"));
            // 
            // buttonReset
            // 
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.Name = "buttonReset";
            this.toolTip.SetToolTip(this.buttonReset, resources.GetString("buttonReset.ToolTip"));
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // checkBoxStartWhenWindowsStarts
            // 
            resources.ApplyResources(this.checkBoxStartWhenWindowsStarts, "checkBoxStartWhenWindowsStarts");
            this.checkBoxStartWhenWindowsStarts.Name = "checkBoxStartWhenWindowsStarts";
            this.toolTip.SetToolTip(this.checkBoxStartWhenWindowsStarts, resources.GetString("checkBoxStartWhenWindowsStarts.ToolTip"));
            this.checkBoxStartWhenWindowsStarts.UseVisualStyleBackColor = true;
            // 
            // buttonDiscordWebhooks
            // 
            resources.ApplyResources(this.buttonDiscordWebhooks, "buttonDiscordWebhooks");
            this.buttonDiscordWebhooks.Name = "buttonDiscordWebhooks";
            this.toolTip.SetToolTip(this.buttonDiscordWebhooks, resources.GetString("buttonDiscordWebhooks.ToolTip"));
            this.buttonDiscordWebhooks.UseVisualStyleBackColor = true;
            this.buttonDiscordWebhooks.Click += new System.EventHandler(this.ButtonDiscordWebhooks_Click);
            // 
            // buttonArcVersionChecking
            // 
            resources.ApplyResources(this.buttonArcVersionChecking, "buttonArcVersionChecking");
            this.buttonArcVersionChecking.Name = "buttonArcVersionChecking";
            this.toolTip.SetToolTip(this.buttonArcVersionChecking, resources.GetString("buttonArcVersionChecking.ToolTip"));
            this.buttonArcVersionChecking.UseVisualStyleBackColor = true;
            this.buttonArcVersionChecking.Click += new System.EventHandler(this.ButtonArcVersionChecking_Click);
            // 
            // buttonPingSettings
            // 
            resources.ApplyResources(this.buttonPingSettings, "buttonPingSettings");
            this.buttonPingSettings.Name = "buttonPingSettings";
            this.toolTip.SetToolTip(this.buttonPingSettings, resources.GetString("buttonPingSettings.ToolTip"));
            this.buttonPingSettings.UseVisualStyleBackColor = true;
            this.buttonPingSettings.Click += new System.EventHandler(this.ButtonPingSettings_Click);
            // 
            // buttonUpdateNow
            // 
            resources.ApplyResources(this.buttonUpdateNow, "buttonUpdateNow");
            this.buttonUpdateNow.Name = "buttonUpdateNow";
            this.toolTip.SetToolTip(this.buttonUpdateNow, resources.GetString("buttonUpdateNow.ToolTip"));
            this.buttonUpdateNow.UseVisualStyleBackColor = true;
            this.buttonUpdateNow.Click += new System.EventHandler(this.ButtonUpdateNow_Click);
            // 
            // timerCheckUpdate
            // 
            this.timerCheckUpdate.Interval = 5400000;
            this.timerCheckUpdate.Tick += new System.EventHandler(this.TimerCheckUpdate_Tick);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // richTextBoxMainConsole
            // 
            resources.ApplyResources(this.richTextBoxMainConsole, "richTextBoxMainConsole");
            this.richTextBoxMainConsole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxMainConsole.Name = "richTextBoxMainConsole";
            this.richTextBoxMainConsole.ReadOnly = true;
            this.toolTip.SetToolTip(this.richTextBoxMainConsole, resources.GetString("richTextBoxMainConsole.ToolTip"));
            this.richTextBoxMainConsole.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBoxUploadInfo_LinkClicked);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.buttonUpdateNow);
            this.Controls.Add(this.groupBoxOtherSettings);
            this.Controls.Add(this.groupBoxArcdpsLogs);
            this.Controls.Add(this.groupBoxTwitchSettings);
            this.Controls.Add(this.richTextBoxMainConsole);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.groupBoxTwitchSettings.ResumeLayout(false);
            this.groupBoxTwitchSettings.PerformLayout();
            this.groupBoxArcdpsLogs.ResumeLayout(false);
            this.groupBoxArcdpsLogs.PerformLayout();
            this.contextMenuStripIcon.ResumeLayout(false);
            this.groupBoxOtherSettings.ResumeLayout(false);
            this.groupBoxOtherSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTwitchSettings;
        private System.Windows.Forms.CheckBox checkBoxUploadLogs;
        private System.Windows.Forms.Button buttonReconnectBot;
        private System.Windows.Forms.GroupBox groupBoxArcdpsLogs;
        private System.Windows.Forms.Button buttonLogsLocation;
        private System.Windows.Forms.Label labelLocationInfo;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.GroupBox groupBoxOtherSettings;
        private System.Windows.Forms.Button buttonPingSettings;
        private System.Windows.Forms.CheckBox checkBoxFileSizeIgnore;
        private System.Windows.Forms.Button buttonChangeTwitchChannel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUploadLogs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFirst;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPostToTwitch;
        private System.Windows.Forms.Button buttonOpenLogs;
        private System.Windows.Forms.Button buttonCustomName;
        private System.Windows.Forms.Button buttonDPSReportServer;
        private System.Windows.Forms.CheckBox checkBoxTrayMinimiseToIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenDPSReportServer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenCustomName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenPingSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorSecond;
        private System.Windows.Forms.Button buttonDisConnectTwitch;
        public System.Windows.Forms.CheckBox checkBoxPostToTwitch;
        private System.Windows.Forms.CheckBox checkBoxTwitchOnlySuccess;
        private System.Windows.Forms.Button buttonArcVersionChecking;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenArcVersionsSettings;
        private System.Windows.Forms.Button buttonBossData;
        private System.Windows.Forms.Button buttonDiscordWebhooks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorThird;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDiscordWebhooks;
        private System.Windows.Forms.Button buttonUpdateNow;
        private System.Windows.Forms.CheckBox checkBoxStartWhenWindowsStarts;
        private System.Windows.Forms.Timer timerCheckUpdate;
        private System.Windows.Forms.Button buttonTwitchCommands;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenTwitchCommands;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonSession;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboBoxMaxUploads;
        private System.Windows.Forms.Label labelMaximumUploads;
        private System.Windows.Forms.RichTextBox richTextBoxMainConsole;
        private System.Windows.Forms.Button buttonGW2API;
        private System.Windows.Forms.Button buttonAleevaSettings;
        private System.Windows.Forms.Button buttonCopyApplicationSession;
    }
}

