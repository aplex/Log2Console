namespace Log2Console
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.quitBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.levelComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.pauseBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.goToFirstLogBtn = new System.Windows.Forms.ToolStripButton();
            this.autoLogToggleBtn = new System.Windows.Forms.ToolStripButton();
            this.goToLastLogBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomOutLogListBtn = new System.Windows.Forms.ToolStripButton();
            this.zoomInLogListBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.clearBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.logDetailsPanelToggleBtn = new System.Windows.Forms.ToolStripButton();
            this.loggersPanelToggleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsBtn = new System.Windows.Forms.ToolStripButton();
            this.receiversBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.pinOnTopBtn = new System.Windows.Forms.ToolStripButton();
            this.versionLabel = new System.Windows.Forms.ToolStripLabel();
            this.loggerTreeView = new System.Windows.Forms.TreeView();
            this.timeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.levelColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loggerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.threadColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.msgColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loggerPanel = new System.Windows.Forms.Panel();
            this.loggerInnerPanel = new System.Windows.Forms.Panel();
            this.loggersToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.closeLoggersPanelBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearLoggersBtn = new System.Windows.Forms.ToolStripButton();
            this.loggerSplitter = new System.Windows.Forms.Splitter();
            this.appNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.exitTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logDetailPanel = new System.Windows.Forms.Panel();
            this.logDetailInnerPanel = new System.Windows.Forms.Panel();
            this.logDetailTextBox = new System.Windows.Forms.TextBox();
            this.logDetailToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.closeLogDetailPanelBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomOutLogDetailsBtn = new System.Windows.Forms.ToolStripButton();
            this.zoomInLogDetailsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.copyLogDetailBtn = new System.Windows.Forms.ToolStripButton();
            this.logDetailSplitter = new System.Windows.Forms.Splitter();
            this.loggerTreeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteLoggerTreeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAllLoggerTreeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logListView = new Log2Console.UI.FlickerFreeListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainToolStrip.SuspendLayout();
            this.loggerPanel.SuspendLayout();
            this.loggerInnerPanel.SuspendLayout();
            this.loggersToolStrip.SuspendLayout();
            this.trayContextMenuStrip.SuspendLayout();
            this.logDetailPanel.SuspendLayout();
            this.logDetailInnerPanel.SuspendLayout();
            this.logDetailToolStrip.SuspendLayout();
            this.loggerTreeContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitBtn,
            this.toolStripLabel3,
            this.levelComboBox,
            this.toolStripSeparator8,
            this.pauseBtn,
            this.toolStripSeparator15,
            this.goToFirstLogBtn,
            this.autoLogToggleBtn,
            this.goToLastLogBtn,
            this.toolStripSeparator13,
            this.zoomOutLogListBtn,
            this.zoomInLogListBtn,
            this.toolStripSeparator10,
            this.clearBtn,
            this.toolStripSeparator1,
            this.toolStripLabel4,
            this.searchTextBox,
            this.toolStripSeparator9,
            this.logDetailsPanelToggleBtn,
            this.loggersPanelToggleBtn,
            this.toolStripSeparator3,
            this.settingsBtn,
            this.receiversBtn,
            this.toolStripSeparator14,
            this.saveBtn,
            this.toolStripSeparator4,
            this.aboutBtn,
            this.toolStripSeparator12,
            this.pinOnTopBtn,
            this.versionLabel});
            this.mainToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.mainToolStrip.Size = new System.Drawing.Size(1682, 34);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "mainToolStrip";
            // 
            // quitBtn
            // 
            this.quitBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.quitBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Image = global::Log2Console.Properties.Resources.close16;
            this.quitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(73, 31);
            this.quitBtn.Text = "Quit";
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel3.Image = global::Log2Console.Properties.Resources.burn16;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(24, 31);
            this.toolStripLabel3.ToolTipText = "Log Level Filter";
            // 
            // levelComboBox
            // 
            this.levelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelComboBox.Items.AddRange(new object[] {
            "Trace",
            "Debug",
            "Info",
            "Warn",
            "Error",
            "Fatal"});
            this.levelComboBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(110, 33);
            this.levelComboBox.ToolTipText = "Log Level Filter";
            this.levelComboBox.SelectedIndexChanged += new System.EventHandler(this.levelComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 34);
            // 
            // pauseBtn
            // 
            this.pauseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseBtn.Image = global::Log2Console.Properties.Resources.Pause16;
            this.pauseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(28, 31);
            this.pauseBtn.ToolTipText = "Enable/Disable All Logs";
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 34);
            // 
            // goToFirstLogBtn
            // 
            this.goToFirstLogBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goToFirstLogBtn.Image = global::Log2Console.Properties.Resources.backward16;
            this.goToFirstLogBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goToFirstLogBtn.Name = "goToFirstLogBtn";
            this.goToFirstLogBtn.Size = new System.Drawing.Size(28, 31);
            this.goToFirstLogBtn.ToolTipText = "Go to First Log Message";
            this.goToFirstLogBtn.Click += new System.EventHandler(this.goToFirstLogBtn_Click);
            // 
            // autoLogToggleBtn
            // 
            this.autoLogToggleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.autoLogToggleBtn.Image = global::Log2Console.Properties.Resources.movefile16;
            this.autoLogToggleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.autoLogToggleBtn.Name = "autoLogToggleBtn";
            this.autoLogToggleBtn.Size = new System.Drawing.Size(28, 31);
            this.autoLogToggleBtn.ToolTipText = "Toggle Auto Log to Last Log Message";
            this.autoLogToggleBtn.Click += new System.EventHandler(this.autoLogToggleBtn_Click);
            // 
            // goToLastLogBtn
            // 
            this.goToLastLogBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goToLastLogBtn.Image = global::Log2Console.Properties.Resources.forward16;
            this.goToLastLogBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goToLastLogBtn.Name = "goToLastLogBtn";
            this.goToLastLogBtn.Size = new System.Drawing.Size(28, 31);
            this.goToLastLogBtn.ToolTipText = "Go to Last Log Message";
            this.goToLastLogBtn.Click += new System.EventHandler(this.goToLastLogBtn_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 34);
            // 
            // zoomOutLogListBtn
            // 
            this.zoomOutLogListBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutLogListBtn.Image = global::Log2Console.Properties.Resources.zoomout16;
            this.zoomOutLogListBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutLogListBtn.Name = "zoomOutLogListBtn";
            this.zoomOutLogListBtn.Size = new System.Drawing.Size(28, 31);
            this.zoomOutLogListBtn.ToolTipText = "Zoom Out Log List Font";
            this.zoomOutLogListBtn.Click += new System.EventHandler(this.zoomOutLogListBtn_Click);
            // 
            // zoomInLogListBtn
            // 
            this.zoomInLogListBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInLogListBtn.Image = global::Log2Console.Properties.Resources.zoomin16;
            this.zoomInLogListBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInLogListBtn.Name = "zoomInLogListBtn";
            this.zoomInLogListBtn.Size = new System.Drawing.Size(28, 31);
            this.zoomInLogListBtn.ToolTipText = "Zoom In Log List Font";
            this.zoomInLogListBtn.Click += new System.EventHandler(this.zoomInLogListBtn_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 34);
            // 
            // clearBtn
            // 
            this.clearBtn.Image = global::Log2Console.Properties.Resources.deletefile16;
            this.clearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(79, 31);
            this.clearBtn.Text = "Clear";
            this.clearBtn.ToolTipText = "Clear Log Messages";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel4.Image = global::Log2Console.Properties.Resources.find16;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(24, 31);
            this.toolStripLabel4.Text = "toolStripLabel4";
            this.toolStripLabel4.ToolTipText = "Search Text in Log Messages";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(148, 33);
            this.searchTextBox.ToolTipText = "Search Text in Log Messages";
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 34);
            // 
            // logDetailsPanelToggleBtn
            // 
            this.logDetailsPanelToggleBtn.Checked = true;
            this.logDetailsPanelToggleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logDetailsPanelToggleBtn.Image = global::Log2Console.Properties.Resources.window16;
            this.logDetailsPanelToggleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.logDetailsPanelToggleBtn.Name = "logDetailsPanelToggleBtn";
            this.logDetailsPanelToggleBtn.Size = new System.Drawing.Size(93, 31);
            this.logDetailsPanelToggleBtn.Text = "Details";
            this.logDetailsPanelToggleBtn.ToolTipText = "Show/Hide Log Details";
            this.logDetailsPanelToggleBtn.Click += new System.EventHandler(this.logDetailsPanelToggleBtn_Click);
            // 
            // loggersPanelToggleBtn
            // 
            this.loggersPanelToggleBtn.Checked = true;
            this.loggersPanelToggleBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loggersPanelToggleBtn.Image = global::Log2Console.Properties.Resources.window16;
            this.loggersPanelToggleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loggersPanelToggleBtn.Name = "loggersPanelToggleBtn";
            this.loggersPanelToggleBtn.Size = new System.Drawing.Size(104, 31);
            this.loggersPanelToggleBtn.Text = "Loggers";
            this.loggersPanelToggleBtn.ToolTipText = "Show/Hide Loggers";
            this.loggersPanelToggleBtn.Click += new System.EventHandler(this.loggersPanelToggleBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Image = global::Log2Console.Properties.Resources.configure16;
            this.settingsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(116, 31);
            this.settingsBtn.Text = "Settings...";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // receiversBtn
            // 
            this.receiversBtn.Image = global::Log2Console.Properties.Resources.configure16;
            this.receiversBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.receiversBtn.Name = "receiversBtn";
            this.receiversBtn.Size = new System.Drawing.Size(125, 31);
            this.receiversBtn.Text = "Receivers...";
            this.receiversBtn.Click += new System.EventHandler(this.receiversBtn_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 34);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Image = global::Log2Console.Properties.Resources.saveas16;
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(28, 31);
            this.saveBtn.Text = "Export Logs...";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Image = global::Log2Console.Properties.Resources.infoabout16;
            this.aboutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(90, 31);
            this.aboutBtn.Text = "About";
            this.aboutBtn.ToolTipText = "About...";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 34);
            // 
            // pinOnTopBtn
            // 
            this.pinOnTopBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pinOnTopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pinOnTopBtn.Image = global::Log2Console.Properties.Resources.cd16;
            this.pinOnTopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pinOnTopBtn.Name = "pinOnTopBtn";
            this.pinOnTopBtn.Size = new System.Drawing.Size(28, 31);
            this.pinOnTopBtn.Text = "Pin on Top";
            this.pinOnTopBtn.Click += new System.EventHandler(this.pinOnTopBtn_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(65, 31);
            this.versionLabel.Text = "Version";
            // 
            // loggerTreeView
            // 
            this.loggerTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggerTreeView.CheckBoxes = true;
            this.loggerTreeView.Indent = 19;
            this.loggerTreeView.Location = new System.Drawing.Point(0, 38);
            this.loggerTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loggerTreeView.Name = "loggerTreeView";
            this.loggerTreeView.PathSeparator = ".";
            this.loggerTreeView.ShowRootLines = false;
            this.loggerTreeView.Size = new System.Drawing.Size(354, 558);
            this.loggerTreeView.TabIndex = 1;
            this.loggerTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.loggerTreeView_AfterCheck);
            this.loggerTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.loggerTreeView_AfterSelect);
            this.loggerTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.loggerTreeView_NodeMouseDoubleClick);
            this.loggerTreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loggerTreeView_MouseUp);
            // 
            // timeColumnHeader
            // 
            this.timeColumnHeader.Text = "Time";
            this.timeColumnHeader.Width = 120;
            // 
            // levelColumnHeader
            // 
            this.levelColumnHeader.Text = "Level";
            this.levelColumnHeader.Width = 48;
            // 
            // loggerColumnHeader
            // 
            this.loggerColumnHeader.Text = "Logger";
            this.loggerColumnHeader.Width = 92;
            // 
            // threadColumnHeader
            // 
            this.threadColumnHeader.Text = "Thread";
            this.threadColumnHeader.Width = 52;
            // 
            // msgColumnHeader
            // 
            this.msgColumnHeader.Text = "Message";
            this.msgColumnHeader.Width = 751;
            // 
            // loggerPanel
            // 
            this.loggerPanel.Controls.Add(this.loggerInnerPanel);
            this.loggerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.loggerPanel.Location = new System.Drawing.Point(1326, 34);
            this.loggerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loggerPanel.Name = "loggerPanel";
            this.loggerPanel.Size = new System.Drawing.Size(356, 598);
            this.loggerPanel.TabIndex = 5;
            // 
            // loggerInnerPanel
            // 
            this.loggerInnerPanel.Controls.Add(this.loggersToolStrip);
            this.loggerInnerPanel.Controls.Add(this.loggerTreeView);
            this.loggerInnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loggerInnerPanel.Location = new System.Drawing.Point(0, 0);
            this.loggerInnerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loggerInnerPanel.Name = "loggerInnerPanel";
            this.loggerInnerPanel.Size = new System.Drawing.Size(356, 598);
            this.loggerInnerPanel.TabIndex = 5;
            // 
            // loggersToolStrip
            // 
            this.loggersToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.loggersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.closeLoggersPanelBtn,
            this.toolStripSeparator2,
            this.clearLoggersBtn});
            this.loggersToolStrip.Location = new System.Drawing.Point(0, 0);
            this.loggersToolStrip.Name = "loggersToolStrip";
            this.loggersToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.loggersToolStrip.Size = new System.Drawing.Size(356, 32);
            this.loggersToolStrip.TabIndex = 0;
            this.loggersToolStrip.Text = "Loggers";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 29);
            this.toolStripLabel1.Text = "Loggers";
            // 
            // closeLoggersPanelBtn
            // 
            this.closeLoggersPanelBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeLoggersPanelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeLoggersPanelBtn.Image = global::Log2Console.Properties.Resources.close16;
            this.closeLoggersPanelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeLoggersPanelBtn.Name = "closeLoggersPanelBtn";
            this.closeLoggersPanelBtn.Size = new System.Drawing.Size(28, 29);
            this.closeLoggersPanelBtn.Text = "Close Loggers View";
            this.closeLoggersPanelBtn.Click += new System.EventHandler(this.closeLoggersPanelBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // clearLoggersBtn
            // 
            this.clearLoggersBtn.Image = global::Log2Console.Properties.Resources.delete16;
            this.clearLoggersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearLoggersBtn.Name = "clearLoggersBtn";
            this.clearLoggersBtn.Size = new System.Drawing.Size(104, 29);
            this.clearLoggersBtn.Text = "Clear All";
            this.clearLoggersBtn.ToolTipText = "Clear All Loggers and Log Messages";
            this.clearLoggersBtn.Click += new System.EventHandler(this.clearLoggersBtn_Click);
            // 
            // loggerSplitter
            // 
            this.loggerSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.loggerSplitter.Location = new System.Drawing.Point(1322, 34);
            this.loggerSplitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loggerSplitter.Name = "loggerSplitter";
            this.loggerSplitter.Size = new System.Drawing.Size(4, 598);
            this.loggerSplitter.TabIndex = 6;
            this.loggerSplitter.TabStop = false;
            // 
            // appNotifyIcon
            // 
            this.appNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.appNotifyIcon.ContextMenuStrip = this.trayContextMenuStrip;
            this.appNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("appNotifyIcon.Icon")));
            this.appNotifyIcon.Text = "appNotifyIcon";
            this.appNotifyIcon.Visible = true;
            this.appNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.appNotifyIcon_MouseDoubleClick);
            // 
            // trayContextMenuStrip
            // 
            this.trayContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreTrayMenuItem,
            this.toolStripSeparator5,
            this.settingsTrayMenuItem,
            this.aboutTrayMenuItem,
            this.toolStripSeparator6,
            this.exitTrayMenuItem});
            this.trayContextMenuStrip.Name = "trayContextMenuStrip";
            this.trayContextMenuStrip.Size = new System.Drawing.Size(269, 136);
            // 
            // restoreTrayMenuItem
            // 
            this.restoreTrayMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.restoreTrayMenuItem.Name = "restoreTrayMenuItem";
            this.restoreTrayMenuItem.Size = new System.Drawing.Size(268, 30);
            this.restoreTrayMenuItem.Text = "Restore";
            this.restoreTrayMenuItem.Click += new System.EventHandler(this.restoreTrayMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(265, 6);
            // 
            // settingsTrayMenuItem
            // 
            this.settingsTrayMenuItem.Name = "settingsTrayMenuItem";
            this.settingsTrayMenuItem.Size = new System.Drawing.Size(268, 30);
            this.settingsTrayMenuItem.Text = "Settings...";
            this.settingsTrayMenuItem.Click += new System.EventHandler(this.settingsTrayMenuItem_Click);
            // 
            // aboutTrayMenuItem
            // 
            this.aboutTrayMenuItem.Name = "aboutTrayMenuItem";
            this.aboutTrayMenuItem.Size = new System.Drawing.Size(268, 30);
            this.aboutTrayMenuItem.Text = "About Log2Console...";
            this.aboutTrayMenuItem.Click += new System.EventHandler(this.aboutTrayMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(265, 6);
            // 
            // exitTrayMenuItem
            // 
            this.exitTrayMenuItem.Name = "exitTrayMenuItem";
            this.exitTrayMenuItem.Size = new System.Drawing.Size(268, 30);
            this.exitTrayMenuItem.Text = "Exit";
            this.exitTrayMenuItem.Click += new System.EventHandler(this.exitTrayMenuItem_Click);
            // 
            // logDetailPanel
            // 
            this.logDetailPanel.Controls.Add(this.logDetailInnerPanel);
            this.logDetailPanel.Controls.Add(this.logDetailToolStrip);
            this.logDetailPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logDetailPanel.Location = new System.Drawing.Point(0, 528);
            this.logDetailPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logDetailPanel.Name = "logDetailPanel";
            this.logDetailPanel.Size = new System.Drawing.Size(1322, 104);
            this.logDetailPanel.TabIndex = 7;
            // 
            // logDetailInnerPanel
            // 
            this.logDetailInnerPanel.Controls.Add(this.logDetailTextBox);
            this.logDetailInnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDetailInnerPanel.Location = new System.Drawing.Point(0, 32);
            this.logDetailInnerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logDetailInnerPanel.Name = "logDetailInnerPanel";
            this.logDetailInnerPanel.Size = new System.Drawing.Size(1322, 72);
            this.logDetailInnerPanel.TabIndex = 1;
            // 
            // logDetailTextBox
            // 
            this.logDetailTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDetailTextBox.Location = new System.Drawing.Point(0, 0);
            this.logDetailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logDetailTextBox.Multiline = true;
            this.logDetailTextBox.Name = "logDetailTextBox";
            this.logDetailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logDetailTextBox.Size = new System.Drawing.Size(1322, 72);
            this.logDetailTextBox.TabIndex = 0;
            this.logDetailTextBox.TextChanged += new System.EventHandler(this.logDetailTextBox_TextChanged);
            // 
            // logDetailToolStrip
            // 
            this.logDetailToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.logDetailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.closeLogDetailPanelBtn,
            this.toolStripSeparator11,
            this.zoomOutLogDetailsBtn,
            this.zoomInLogDetailsBtn,
            this.toolStripSeparator7,
            this.copyLogDetailBtn});
            this.logDetailToolStrip.Location = new System.Drawing.Point(0, 0);
            this.logDetailToolStrip.Name = "logDetailToolStrip";
            this.logDetailToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.logDetailToolStrip.Size = new System.Drawing.Size(1322, 32);
            this.logDetailToolStrip.TabIndex = 0;
            this.logDetailToolStrip.Text = "Log Message Details";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(149, 29);
            this.toolStripLabel2.Text = "Message Details";
            // 
            // closeLogDetailPanelBtn
            // 
            this.closeLogDetailPanelBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeLogDetailPanelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeLogDetailPanelBtn.Image = global::Log2Console.Properties.Resources.close16;
            this.closeLogDetailPanelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeLogDetailPanelBtn.Name = "closeLogDetailPanelBtn";
            this.closeLogDetailPanelBtn.Size = new System.Drawing.Size(28, 29);
            this.closeLogDetailPanelBtn.Text = "Close Log Detail Panel";
            this.closeLogDetailPanelBtn.Click += new System.EventHandler(this.closeLogDetailPanelBtn_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 32);
            // 
            // zoomOutLogDetailsBtn
            // 
            this.zoomOutLogDetailsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutLogDetailsBtn.Image = global::Log2Console.Properties.Resources.zoomout16;
            this.zoomOutLogDetailsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutLogDetailsBtn.Name = "zoomOutLogDetailsBtn";
            this.zoomOutLogDetailsBtn.Size = new System.Drawing.Size(28, 29);
            this.zoomOutLogDetailsBtn.ToolTipText = "Zoom Out Log Details Font";
            this.zoomOutLogDetailsBtn.Click += new System.EventHandler(this.zoomOutLogDetailsBtn_Click);
            // 
            // zoomInLogDetailsBtn
            // 
            this.zoomInLogDetailsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInLogDetailsBtn.Image = global::Log2Console.Properties.Resources.zoomin16;
            this.zoomInLogDetailsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInLogDetailsBtn.Name = "zoomInLogDetailsBtn";
            this.zoomInLogDetailsBtn.Size = new System.Drawing.Size(28, 29);
            this.zoomInLogDetailsBtn.ToolTipText = "Zoom In Log Details Font";
            this.zoomInLogDetailsBtn.Click += new System.EventHandler(this.zoomInLogDetailsBtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 32);
            // 
            // copyLogDetailBtn
            // 
            this.copyLogDetailBtn.Image = global::Log2Console.Properties.Resources.documentsorcopy16;
            this.copyLogDetailBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyLogDetailBtn.Name = "copyLogDetailBtn";
            this.copyLogDetailBtn.Size = new System.Drawing.Size(82, 29);
            this.copyLogDetailBtn.Text = "Copy";
            this.copyLogDetailBtn.Click += new System.EventHandler(this.copyLogDetailBtn_Click);
            // 
            // logDetailSplitter
            // 
            this.logDetailSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logDetailSplitter.Location = new System.Drawing.Point(0, 524);
            this.logDetailSplitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logDetailSplitter.Name = "logDetailSplitter";
            this.logDetailSplitter.Size = new System.Drawing.Size(1322, 4);
            this.logDetailSplitter.TabIndex = 8;
            this.logDetailSplitter.TabStop = false;
            // 
            // loggerTreeContextMenuStrip
            // 
            this.loggerTreeContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.loggerTreeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteLoggerTreeMenuItem,
            this.toolStripSeparator16,
            this.deleteAllLoggerTreeMenuItem});
            this.loggerTreeContextMenuStrip.Name = "loggerTreeContextMenuStrip";
            this.loggerTreeContextMenuStrip.Size = new System.Drawing.Size(231, 70);
            // 
            // deleteLoggerTreeMenuItem
            // 
            this.deleteLoggerTreeMenuItem.Name = "deleteLoggerTreeMenuItem";
            this.deleteLoggerTreeMenuItem.Size = new System.Drawing.Size(230, 30);
            this.deleteLoggerTreeMenuItem.Text = "Clear Logger";
            this.deleteLoggerTreeMenuItem.Click += new System.EventHandler(this.deleteLoggerTreeMenuItem_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(227, 6);
            // 
            // deleteAllLoggerTreeMenuItem
            // 
            this.deleteAllLoggerTreeMenuItem.Name = "deleteAllLoggerTreeMenuItem";
            this.deleteAllLoggerTreeMenuItem.Size = new System.Drawing.Size(230, 30);
            this.deleteAllLoggerTreeMenuItem.Text = "Clear All Loggers";
            this.deleteAllLoggerTreeMenuItem.Click += new System.EventHandler(this.deleteAllLoggerTreeMenuItem_Click);
            // 
            // logListView
            // 
            this.logListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.logListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logListView.FullRowSelect = true;
            this.logListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.logListView.HideSelection = false;
            this.logListView.Location = new System.Drawing.Point(0, 34);
            this.logListView.Margin = new System.Windows.Forms.Padding(4);
            this.logListView.MultiSelect = false;
            this.logListView.Name = "logListView";
            this.logListView.ShowItemToolTips = true;
            this.logListView.Size = new System.Drawing.Size(1322, 490);
            this.logListView.TabIndex = 0;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            this.logListView.Scroll += new System.EventHandler(this.logListView_Scroll);
            this.logListView.SelectedIndexChanged += new System.EventHandler(this.logListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Level";
            this.columnHeader2.Width = 48;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Logger";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thread";
            this.columnHeader4.Width = 52;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Message";
            this.columnHeader5.Width = 540;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1682, 632);
            this.Controls.Add(this.logListView);
            this.Controls.Add(this.logDetailSplitter);
            this.Controls.Add(this.logDetailPanel);
            this.Controls.Add(this.loggerSplitter);
            this.Controls.Add(this.loggerPanel);
            this.Controls.Add(this.mainToolStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Log2Console";
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.loggerPanel.ResumeLayout(false);
            this.loggerInnerPanel.ResumeLayout(false);
            this.loggerInnerPanel.PerformLayout();
            this.loggersToolStrip.ResumeLayout(false);
            this.loggersToolStrip.PerformLayout();
            this.trayContextMenuStrip.ResumeLayout(false);
            this.logDetailPanel.ResumeLayout(false);
            this.logDetailPanel.PerformLayout();
            this.logDetailInnerPanel.ResumeLayout(false);
            this.logDetailInnerPanel.PerformLayout();
            this.logDetailToolStrip.ResumeLayout(false);
            this.logDetailToolStrip.PerformLayout();
            this.loggerTreeContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton clearBtn;
        private System.Windows.Forms.ToolStripButton quitBtn;
        private System.Windows.Forms.ColumnHeader timeColumnHeader;
        private System.Windows.Forms.ColumnHeader levelColumnHeader;
        private System.Windows.Forms.ColumnHeader loggerColumnHeader;
        private System.Windows.Forms.ColumnHeader threadColumnHeader;
        private System.Windows.Forms.ColumnHeader msgColumnHeader;
        private Log2Console.UI.FlickerFreeListView logListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TreeView loggerTreeView;
        private System.Windows.Forms.Panel loggerPanel;
        private System.Windows.Forms.Panel loggerInnerPanel;
        private System.Windows.Forms.Splitter loggerSplitter;
        private System.Windows.Forms.ToolStrip loggersToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton closeLoggersPanelBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton loggersPanelToggleBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton clearLoggersBtn;
		private System.Windows.Forms.NotifyIcon appNotifyIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton aboutBtn;
        private System.Windows.Forms.ToolStripButton settingsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ContextMenuStrip trayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem restoreTrayMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutTrayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsTrayMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem exitTrayMenuItem;
        private System.Windows.Forms.Panel logDetailPanel;
        private System.Windows.Forms.Splitter logDetailSplitter;
        private System.Windows.Forms.Panel logDetailInnerPanel;
        private System.Windows.Forms.TextBox logDetailTextBox;
        private System.Windows.Forms.ToolStrip logDetailToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton closeLogDetailPanelBtn;
        private System.Windows.Forms.ToolStripButton logDetailsPanelToggleBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton copyLogDetailBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox levelComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton zoomOutLogListBtn;
        private System.Windows.Forms.ToolStripButton zoomInLogListBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton zoomOutLogDetailsBtn;
        private System.Windows.Forms.ToolStripButton zoomInLogDetailsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton pinOnTopBtn;
        private System.Windows.Forms.ToolStripButton pauseBtn;
        private System.Windows.Forms.ToolStripButton receiversBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripLabel versionLabel;
        private System.Windows.Forms.ToolStripButton autoLogToggleBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton goToFirstLogBtn;
        private System.Windows.Forms.ToolStripButton goToLastLogBtn;
        private System.Windows.Forms.ContextMenuStrip loggerTreeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteLoggerTreeMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripMenuItem deleteAllLoggerTreeMenuItem;
    }
}

