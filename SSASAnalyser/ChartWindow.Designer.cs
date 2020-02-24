namespace SSASAnalyser
{
    partial class ChartWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SaveImageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTxtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SeriesButtons = new System.Windows.Forms.DataGridView();
            this.SeriesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowSeries = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TimeAnalysisGridView = new System.Windows.Forms.DataGridView();
            this.QueryNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeanTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandardDeviationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarianceColumnHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadChartStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeriesButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeAnalysisGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveImageMenu,
            this.SaveTxtMenu,
            this.LoadChartStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(5, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SaveImageMenu
            // 
            this.SaveImageMenu.Name = "SaveImageMenu";
            this.SaveImageMenu.Size = new System.Drawing.Size(79, 20);
            this.SaveImageMenu.Text = "Save Image";
            this.SaveImageMenu.Click += new System.EventHandler(this.SaveImageMenu_Click);
            // 
            // SaveTxtMenu
            // 
            this.SaveTxtMenu.Name = "SaveTxtMenu";
            this.SaveTxtMenu.Size = new System.Drawing.Size(61, 20);
            this.SaveTxtMenu.Text = "Save Txt";
            this.SaveTxtMenu.Click += new System.EventHandler(this.SaveTxtMenu_Click);
            // 
            // ResultChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea2);
            this.ResultChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ResultChart.Legends.Add(legend2);
            this.ResultChart.Location = new System.Drawing.Point(0, 0);
            this.ResultChart.Name = "ResultChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ResultChart.Series.Add(series2);
            this.ResultChart.Size = new System.Drawing.Size(675, 412);
            this.ResultChart.TabIndex = 0;
            this.ResultChart.Text = "m";
            // 
            // SeriesButtons
            // 
            this.SeriesButtons.AllowUserToAddRows = false;
            this.SeriesButtons.AllowUserToDeleteRows = false;
            this.SeriesButtons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeriesButtons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeriesName,
            this.ShowSeries});
            this.SeriesButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeriesButtons.Location = new System.Drawing.Point(0, 0);
            this.SeriesButtons.Name = "SeriesButtons";
            this.SeriesButtons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SeriesButtons.Size = new System.Drawing.Size(238, 412);
            this.SeriesButtons.TabIndex = 3;
            this.SeriesButtons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeriesButtons_CellContentClick);
            // 
            // SeriesName
            // 
            this.SeriesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SeriesName.FillWeight = 50F;
            this.SeriesName.HeaderText = "Series Name";
            this.SeriesName.Name = "SeriesName";
            this.SeriesName.ReadOnly = true;
            // 
            // ShowSeries
            // 
            this.ShowSeries.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShowSeries.HeaderText = "Show";
            this.ShowSeries.Name = "ShowSeries";
            this.ShowSeries.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(5, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ResultChart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SeriesButtons);
            this.splitContainer1.Size = new System.Drawing.Size(917, 412);
            this.splitContainer1.SplitterDistance = 675;
            this.splitContainer1.TabIndex = 5;
            // 
            // TimeAnalysisGridView
            // 
            this.TimeAnalysisGridView.AllowUserToAddRows = false;
            this.TimeAnalysisGridView.AllowUserToDeleteRows = false;
            this.TimeAnalysisGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeAnalysisGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QueryNameColumn,
            this.MeanTimeColumn,
            this.StandardDeviationColumn,
            this.VarianceColumnHeader});
            this.TimeAnalysisGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeAnalysisGridView.Location = new System.Drawing.Point(5, 436);
            this.TimeAnalysisGridView.Name = "TimeAnalysisGridView";
            this.TimeAnalysisGridView.ReadOnly = true;
            this.TimeAnalysisGridView.Size = new System.Drawing.Size(917, 74);
            this.TimeAnalysisGridView.TabIndex = 6;
            // 
            // QueryNameColumn
            // 
            this.QueryNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QueryNameColumn.HeaderText = "Query Name";
            this.QueryNameColumn.Name = "QueryNameColumn";
            this.QueryNameColumn.ReadOnly = true;
            // 
            // MeanTimeColumn
            // 
            this.MeanTimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MeanTimeColumn.HeaderText = "Mean Time";
            this.MeanTimeColumn.Name = "MeanTimeColumn";
            this.MeanTimeColumn.ReadOnly = true;
            // 
            // StandardDeviationColumn
            // 
            this.StandardDeviationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StandardDeviationColumn.HeaderText = "Standard Deviation";
            this.StandardDeviationColumn.Name = "StandardDeviationColumn";
            this.StandardDeviationColumn.ReadOnly = true;
            // 
            // VarianceColumnHeader
            // 
            this.VarianceColumnHeader.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VarianceColumnHeader.HeaderText = "Variance";
            this.VarianceColumnHeader.Name = "VarianceColumnHeader";
            this.VarianceColumnHeader.ReadOnly = true;
            // 
            // LoadChartStripMenu
            // 
            this.LoadChartStripMenu.Name = "LoadChartStripMenu";
            this.LoadChartStripMenu.Size = new System.Drawing.Size(45, 20);
            this.LoadChartStripMenu.Text = "Load";
            this.LoadChartStripMenu.Click += new System.EventHandler(this.LoadChartStripMenu_Click);
            // 
            // ChartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 515);
            this.Controls.Add(this.TimeAnalysisGridView);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChartWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Text = "Chart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChartForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeriesButtons)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeAnalysisGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SaveImageMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveTxtMenu;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResultChart;
        private System.Windows.Forms.DataGridView SeriesButtons;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriesName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ShowSeries;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView TimeAnalysisGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueryNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeanTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandardDeviationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarianceColumnHeader;
        private System.Windows.Forms.ToolStripMenuItem LoadChartStripMenu;
    }
}