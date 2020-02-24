namespace SSASAnalyser
{
    partial class ConnectWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSourceInput = new System.Windows.Forms.TextBox();
            this.catalogInput = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catalog";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataSourceInput
            // 
            this.dataSourceInput.AllowDrop = true;
            this.dataSourceInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSourceInput.Location = new System.Drawing.Point(84, 3);
            this.dataSourceInput.Name = "dataSourceInput";
            this.dataSourceInput.Size = new System.Drawing.Size(140, 20);
            this.dataSourceInput.TabIndex = 2;
            this.dataSourceInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataSourceInput_DragDrop);
            this.dataSourceInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataSourceInput_DragEnter);
            // 
            // catalogInput
            // 
            this.catalogInput.AllowDrop = true;
            this.catalogInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalogInput.Location = new System.Drawing.Point(84, 29);
            this.catalogInput.Name = "catalogInput";
            this.catalogInput.Size = new System.Drawing.Size(140, 20);
            this.catalogInput.TabIndex = 3;
            this.catalogInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.CatalogInput_DragDrop);
            this.catalogInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataSourceInput_DragEnter);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(3, 55);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 24);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OKButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(84, 55);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(140, 24);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.ColumnCount = 2;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainPanel.Controls.Add(this.label1, 0, 0);
            this.MainPanel.Controls.Add(this.okButton, 0, 2);
            this.MainPanel.Controls.Add(this.cancelButton, 1, 2);
            this.MainPanel.Controls.Add(this.label2, 0, 1);
            this.MainPanel.Controls.Add(this.dataSourceInput, 1, 0);
            this.MainPanel.Controls.Add(this.catalogInput, 1, 1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 3;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainPanel.Size = new System.Drawing.Size(227, 82);
            this.MainPanel.TabIndex = 6;
            // 
            // ConnectWindow
            // 
            this.AcceptButton = this.okButton;
            this.AllowDrop = true;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(227, 82);
            this.Controls.Add(this.MainPanel);
            this.Name = "ConnectWindow";
            this.Text = "Connect";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataSourceInput;
        private System.Windows.Forms.TextBox catalogInput;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
    }
}