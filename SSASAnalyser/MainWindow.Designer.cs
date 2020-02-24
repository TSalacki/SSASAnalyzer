namespace SSASAnalyser
{
    partial class MainWindow
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
            this.queryInputBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ConnectionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multidimensionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacheMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCacheOption = new System.Windows.Forms.ToolStripMenuItem();
            this.dontClearCacheOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearCacheNowButton = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadQueryPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveQueryPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuerySelectionList = new System.Windows.Forms.ListBox();
            this.AddQueryButton = new System.Windows.Forms.Button();
            this.RemoveQueryButton = new System.Windows.Forms.Button();
            this.SaveQueryButton = new System.Windows.Forms.Button();
            this.RightPanelContainer = new System.Windows.Forms.SplitContainer();
            this.ButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RenameQueryButton = new System.Windows.Forms.Button();
            this.MainWindowContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TabConLabel = new System.Windows.Forms.Label();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.AlreadyDoneLabel = new System.Windows.Forms.Label();
            this.RepetitionsLabel = new System.Windows.Forms.Label();
            this.repetitionsNumberInput = new System.Windows.Forms.TextBox();
            this.repetitionsNumberCounter = new System.Windows.Forms.TextBox();
            this.MultidimensionalConnectionStatus = new System.Windows.Forms.Button();
            this.completitionProgressBar = new System.Windows.Forms.ProgressBar();
            this.MultConLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.TabularConnectionStatus = new System.Windows.Forms.Button();
            this.LeftPanelContainer = new System.Windows.Forms.SplitContainer();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightPanelContainer)).BeginInit();
            this.RightPanelContainer.Panel1.SuspendLayout();
            this.RightPanelContainer.Panel2.SuspendLayout();
            this.RightPanelContainer.SuspendLayout();
            this.ButtonTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowContainer)).BeginInit();
            this.MainWindowContainer.Panel1.SuspendLayout();
            this.MainWindowContainer.Panel2.SuspendLayout();
            this.MainWindowContainer.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPanelContainer)).BeginInit();
            this.LeftPanelContainer.Panel1.SuspendLayout();
            this.LeftPanelContainer.Panel2.SuspendLayout();
            this.LeftPanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // queryInputBox
            // 
            this.queryInputBox.AcceptsReturn = true;
            this.queryInputBox.AcceptsTab = true;
            this.queryInputBox.AllowDrop = true;
            this.queryInputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryInputBox.Location = new System.Drawing.Point(0, 0);
            this.queryInputBox.Multiline = true;
            this.queryInputBox.Name = "queryInputBox";
            this.queryInputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.queryInputBox.Size = new System.Drawing.Size(816, 424);
            this.queryInputBox.TabIndex = 0;
            this.queryInputBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.QueryBox_DragDrop);
            this.queryInputBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.QueryBox_DragEnter);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionsMenu,
            this.cacheMenu,
            this.chartToolStripMenuItem,
            this.queryPlanToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(5, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(967, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // ConnectionsMenu
            // 
            this.ConnectionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.ConnectionsMenu.Name = "ConnectionsMenu";
            this.ConnectionsMenu.Size = new System.Drawing.Size(86, 20);
            this.ConnectionsMenu.Text = "Connections";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multidimensionalToolStripMenuItem,
            this.tabularToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // multidimensionalToolStripMenuItem
            // 
            this.multidimensionalToolStripMenuItem.Name = "multidimensionalToolStripMenuItem";
            this.multidimensionalToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.multidimensionalToolStripMenuItem.Text = "Multidimensional";
            this.multidimensionalToolStripMenuItem.Click += new System.EventHandler(this.ConnectToMultidimensionalMenuItem_Click);
            // 
            // tabularToolStripMenuItem
            // 
            this.tabularToolStripMenuItem.Name = "tabularToolStripMenuItem";
            this.tabularToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tabularToolStripMenuItem.Text = "Tabular";
            this.tabularToolStripMenuItem.Click += new System.EventHandler(this.ConnectToTabularMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // cacheMenu
            // 
            this.cacheMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearCacheOption,
            this.dontClearCacheOption,
            this.ClearCacheNowButton});
            this.cacheMenu.Name = "cacheMenu";
            this.cacheMenu.Size = new System.Drawing.Size(52, 20);
            this.cacheMenu.Text = "Cache";
            // 
            // clearCacheOption
            // 
            this.clearCacheOption.Name = "clearCacheOption";
            this.clearCacheOption.Size = new System.Drawing.Size(133, 22);
            this.clearCacheOption.Text = "Clear";
            this.clearCacheOption.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // dontClearCacheOption
            // 
            this.dontClearCacheOption.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dontClearCacheOption.Name = "dontClearCacheOption";
            this.dontClearCacheOption.Size = new System.Drawing.Size(133, 22);
            this.dontClearCacheOption.Text = "Don\'t Clear";
            this.dontClearCacheOption.Click += new System.EventHandler(this.DontClearToolStripMenuItem_Click);
            // 
            // ClearCacheNowButton
            // 
            this.ClearCacheNowButton.Name = "ClearCacheNowButton";
            this.ClearCacheNowButton.Size = new System.Drawing.Size(133, 22);
            this.ClearCacheNowButton.Text = "Clear Now";
            this.ClearCacheNowButton.Click += new System.EventHandler(this.ClearNowToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click_1);
            // 
            // queryPlanToolStripMenuItem
            // 
            this.queryPlanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadQueryPlanToolStripMenuItem,
            this.saveQueryPlanToolStripMenuItem});
            this.queryPlanToolStripMenuItem.Name = "queryPlanToolStripMenuItem";
            this.queryPlanToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.queryPlanToolStripMenuItem.Text = "QueryPlan";
            // 
            // loadQueryPlanToolStripMenuItem
            // 
            this.loadQueryPlanToolStripMenuItem.Name = "loadQueryPlanToolStripMenuItem";
            this.loadQueryPlanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadQueryPlanToolStripMenuItem.Text = "Load";
            this.loadQueryPlanToolStripMenuItem.Click += new System.EventHandler(this.LoadQueryPlanMenuItem_Click);
            // 
            // saveQueryPlanToolStripMenuItem
            // 
            this.saveQueryPlanToolStripMenuItem.Name = "saveQueryPlanToolStripMenuItem";
            this.saveQueryPlanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveQueryPlanToolStripMenuItem.Text = "Save";
            this.saveQueryPlanToolStripMenuItem.Click += new System.EventHandler(this.SaveQueryPlanMenuItem_Click);
            // 
            // QuerySelectionList
            // 
            this.QuerySelectionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuerySelectionList.FormattingEnabled = true;
            this.QuerySelectionList.Location = new System.Drawing.Point(0, 0);
            this.QuerySelectionList.Name = "QuerySelectionList";
            this.QuerySelectionList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuerySelectionList.Size = new System.Drawing.Size(147, 371);
            this.QuerySelectionList.TabIndex = 15;
            this.QuerySelectionList.SelectedValueChanged += new System.EventHandler(this.QueryList_SelectedValueChanged);
            // 
            // AddQueryButton
            // 
            this.AddQueryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddQueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddQueryButton.Location = new System.Drawing.Point(3, 65);
            this.AddQueryButton.Name = "AddQueryButton";
            this.AddQueryButton.Size = new System.Drawing.Size(141, 25);
            this.AddQueryButton.TabIndex = 14;
            this.AddQueryButton.Text = "Add";
            this.AddQueryButton.UseVisualStyleBackColor = true;
            this.AddQueryButton.Click += new System.EventHandler(this.AddQueryButton_Click);
            // 
            // RemoveQueryButton
            // 
            this.RemoveQueryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveQueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveQueryButton.Location = new System.Drawing.Point(3, 3);
            this.RemoveQueryButton.Name = "RemoveQueryButton";
            this.RemoveQueryButton.Size = new System.Drawing.Size(141, 25);
            this.RemoveQueryButton.TabIndex = 15;
            this.RemoveQueryButton.Text = "Remove";
            this.RemoveQueryButton.UseVisualStyleBackColor = true;
            this.RemoveQueryButton.Click += new System.EventHandler(this.RemoveQueryButton_Click);
            // 
            // SaveQueryButton
            // 
            this.SaveQueryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveQueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveQueryButton.Location = new System.Drawing.Point(3, 34);
            this.SaveQueryButton.Name = "SaveQueryButton";
            this.SaveQueryButton.Size = new System.Drawing.Size(141, 25);
            this.SaveQueryButton.TabIndex = 16;
            this.SaveQueryButton.Text = "Save";
            this.SaveQueryButton.UseVisualStyleBackColor = true;
            this.SaveQueryButton.Click += new System.EventHandler(this.SaveQueryButton_Click);
            // 
            // RightPanelContainer
            // 
            this.RightPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.RightPanelContainer.Name = "RightPanelContainer";
            this.RightPanelContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RightPanelContainer.Panel1
            // 
            this.RightPanelContainer.Panel1.Controls.Add(this.QuerySelectionList);
            // 
            // RightPanelContainer.Panel2
            // 
            this.RightPanelContainer.Panel2.Controls.Add(this.ButtonTableLayout);
            this.RightPanelContainer.Size = new System.Drawing.Size(147, 499);
            this.RightPanelContainer.SplitterDistance = 371;
            this.RightPanelContainer.TabIndex = 17;
            // 
            // ButtonTableLayout
            // 
            this.ButtonTableLayout.ColumnCount = 1;
            this.ButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTableLayout.Controls.Add(this.AddQueryButton, 0, 2);
            this.ButtonTableLayout.Controls.Add(this.RemoveQueryButton, 0, 0);
            this.ButtonTableLayout.Controls.Add(this.SaveQueryButton, 0, 1);
            this.ButtonTableLayout.Controls.Add(this.RenameQueryButton, 0, 3);
            this.ButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTableLayout.Location = new System.Drawing.Point(0, 0);
            this.ButtonTableLayout.Name = "ButtonTableLayout";
            this.ButtonTableLayout.RowCount = 4;
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayout.Size = new System.Drawing.Size(147, 124);
            this.ButtonTableLayout.TabIndex = 17;
            // 
            // RenameQueryButton
            // 
            this.RenameQueryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RenameQueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenameQueryButton.Location = new System.Drawing.Point(3, 96);
            this.RenameQueryButton.Name = "RenameQueryButton";
            this.RenameQueryButton.Size = new System.Drawing.Size(141, 25);
            this.RenameQueryButton.TabIndex = 17;
            this.RenameQueryButton.Text = "Rename";
            this.RenameQueryButton.UseVisualStyleBackColor = true;
            this.RenameQueryButton.Click += new System.EventHandler(this.RenameQueryButton_Click);
            // 
            // MainWindowContainer
            // 
            this.MainWindowContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowContainer.Location = new System.Drawing.Point(5, 24);
            this.MainWindowContainer.Name = "MainWindowContainer";
            // 
            // MainWindowContainer.Panel1
            // 
            this.MainWindowContainer.Panel1.Controls.Add(this.LeftPanelContainer);
            // 
            // MainWindowContainer.Panel2
            // 
            this.MainWindowContainer.Panel2.Controls.Add(this.RightPanelContainer);
            this.MainWindowContainer.Size = new System.Drawing.Size(967, 499);
            this.MainWindowContainer.SplitterDistance = 816;
            this.MainWindowContainer.TabIndex = 19;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 7;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.TabularConnectionStatus, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.runButton, 6, 1);
            this.tableLayoutPanel.Controls.Add(this.MultConLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.completitionProgressBar, 5, 1);
            this.tableLayoutPanel.Controls.Add(this.MultidimensionalConnectionStatus, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.repetitionsNumberCounter, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.repetitionsNumberInput, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.RepetitionsLabel, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.AlreadyDoneLabel, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.ProgressLabel, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.TabConLabel, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(816, 71);
            this.tableLayoutPanel.TabIndex = 14;
            // 
            // TabConLabel
            // 
            this.TabConLabel.AutoSize = true;
            this.TabConLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabConLabel.Location = new System.Drawing.Point(3, 0);
            this.TabConLabel.Name = "TabConLabel";
            this.TabConLabel.Size = new System.Drawing.Size(138, 35);
            this.TabConLabel.TabIndex = 3;
            this.TabConLabel.Text = "TabularConnection";
            this.TabConLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(365, 35);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(48, 36);
            this.ProgressLabel.TabIndex = 13;
            this.ProgressLabel.Text = "Progress";
            this.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlreadyDoneLabel
            // 
            this.AlreadyDoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlreadyDoneLabel.AutoSize = true;
            this.AlreadyDoneLabel.Location = new System.Drawing.Point(228, 35);
            this.AlreadyDoneLabel.Name = "AlreadyDoneLabel";
            this.AlreadyDoneLabel.Size = new System.Drawing.Size(71, 36);
            this.AlreadyDoneLabel.TabIndex = 11;
            this.AlreadyDoneLabel.Text = "Already Done";
            this.AlreadyDoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RepetitionsLabel
            // 
            this.RepetitionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepetitionsLabel.AutoSize = true;
            this.RepetitionsLabel.Location = new System.Drawing.Point(228, 0);
            this.RepetitionsLabel.Name = "RepetitionsLabel";
            this.RepetitionsLabel.Size = new System.Drawing.Size(71, 35);
            this.RepetitionsLabel.TabIndex = 8;
            this.RepetitionsLabel.Text = "Repetitions";
            this.RepetitionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repetitionsNumberInput
            // 
            this.repetitionsNumberInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repetitionsNumberInput.Location = new System.Drawing.Point(305, 3);
            this.repetitionsNumberInput.Name = "repetitionsNumberInput";
            this.repetitionsNumberInput.Size = new System.Drawing.Size(54, 20);
            this.repetitionsNumberInput.TabIndex = 9;
            this.repetitionsNumberInput.Text = "1";
            this.repetitionsNumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RepetitionsInput_KeyPress);
            // 
            // repetitionsNumberCounter
            // 
            this.repetitionsNumberCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repetitionsNumberCounter.Location = new System.Drawing.Point(305, 38);
            this.repetitionsNumberCounter.Name = "repetitionsNumberCounter";
            this.repetitionsNumberCounter.ReadOnly = true;
            this.repetitionsNumberCounter.Size = new System.Drawing.Size(54, 20);
            this.repetitionsNumberCounter.TabIndex = 10;
            // 
            // MultidimensionalConnectionStatus
            // 
            this.MultidimensionalConnectionStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MultidimensionalConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.MultidimensionalConnectionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultidimensionalConnectionStatus.Enabled = false;
            this.MultidimensionalConnectionStatus.Location = new System.Drawing.Point(147, 38);
            this.MultidimensionalConnectionStatus.Name = "MultidimensionalConnectionStatus";
            this.MultidimensionalConnectionStatus.Size = new System.Drawing.Size(75, 30);
            this.MultidimensionalConnectionStatus.TabIndex = 7;
            this.MultidimensionalConnectionStatus.UseVisualStyleBackColor = false;
            // 
            // completitionProgressBar
            // 
            this.completitionProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completitionProgressBar.Location = new System.Drawing.Point(419, 38);
            this.completitionProgressBar.Name = "completitionProgressBar";
            this.completitionProgressBar.Size = new System.Drawing.Size(174, 30);
            this.completitionProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.completitionProgressBar.TabIndex = 12;
            // 
            // MultConLabel
            // 
            this.MultConLabel.AutoSize = true;
            this.MultConLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultConLabel.Location = new System.Drawing.Point(3, 35);
            this.MultConLabel.Name = "MultConLabel";
            this.MultConLabel.Size = new System.Drawing.Size(138, 36);
            this.MultConLabel.TabIndex = 5;
            this.MultConLabel.Text = "MultidimensionalConnection";
            this.MultConLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.AutoSize = true;
            this.runButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(599, 38);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(214, 30);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunQueryPlanButtonClick);
            // 
            // TabularConnectionStatus
            // 
            this.TabularConnectionStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TabularConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.TabularConnectionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabularConnectionStatus.Enabled = false;
            this.TabularConnectionStatus.Location = new System.Drawing.Point(147, 3);
            this.TabularConnectionStatus.Name = "TabularConnectionStatus";
            this.TabularConnectionStatus.Size = new System.Drawing.Size(75, 29);
            this.TabularConnectionStatus.TabIndex = 6;
            this.TabularConnectionStatus.UseVisualStyleBackColor = false;
            // 
            // LeftPanelContainer
            // 
            this.LeftPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.LeftPanelContainer.Name = "LeftPanelContainer";
            this.LeftPanelContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // LeftPanelContainer.Panel1
            // 
            this.LeftPanelContainer.Panel1.Controls.Add(this.queryInputBox);
            // 
            // LeftPanelContainer.Panel2
            // 
            this.LeftPanelContainer.Panel2.Controls.Add(this.tableLayoutPanel);
            this.LeftPanelContainer.Size = new System.Drawing.Size(816, 499);
            this.LeftPanelContainer.SplitterDistance = 424;
            this.LeftPanelContainer.TabIndex = 18;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 528);
            this.Controls.Add(this.MainWindowContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Text = "SSASAnalizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.RightPanelContainer.Panel1.ResumeLayout(false);
            this.RightPanelContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightPanelContainer)).EndInit();
            this.RightPanelContainer.ResumeLayout(false);
            this.ButtonTableLayout.ResumeLayout(false);
            this.MainWindowContainer.Panel1.ResumeLayout(false);
            this.MainWindowContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainWindowContainer)).EndInit();
            this.MainWindowContainer.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.LeftPanelContainer.Panel1.ResumeLayout(false);
            this.LeftPanelContainer.Panel1.PerformLayout();
            this.LeftPanelContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftPanelContainer)).EndInit();
            this.LeftPanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox queryInputBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ConnectionsMenu;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multidimensionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacheMenu;
        private System.Windows.Forms.ToolStripMenuItem clearCacheOption;
        private System.Windows.Forms.ToolStripMenuItem dontClearCacheOption;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearCacheNowButton;
        private System.Windows.Forms.ListBox QuerySelectionList;
        private System.Windows.Forms.Button AddQueryButton;
        private System.Windows.Forms.Button RemoveQueryButton;
        private System.Windows.Forms.Button SaveQueryButton;
        private System.Windows.Forms.SplitContainer RightPanelContainer;
        private System.Windows.Forms.ToolStripMenuItem queryPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadQueryPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveQueryPlanToolStripMenuItem;
        private System.Windows.Forms.SplitContainer MainWindowContainer;
        private System.Windows.Forms.TableLayoutPanel ButtonTableLayout;
        private System.Windows.Forms.Button RenameQueryButton;
        private System.Windows.Forms.SplitContainer LeftPanelContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button TabularConnectionStatus;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label MultConLabel;
        private System.Windows.Forms.ProgressBar completitionProgressBar;
        private System.Windows.Forms.Button MultidimensionalConnectionStatus;
        private System.Windows.Forms.TextBox repetitionsNumberCounter;
        private System.Windows.Forms.TextBox repetitionsNumberInput;
        private System.Windows.Forms.Label RepetitionsLabel;
        private System.Windows.Forms.Label AlreadyDoneLabel;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label TabConLabel;
    }
}

