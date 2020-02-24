namespace SSASAnalyser
{
    partial class QueryNameInputWindow
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
            this.OkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.queryNameInput = new System.Windows.Forms.TextBox();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OkButton.Location = new System.Drawing.Point(0, 0);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(135, 25);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(0, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(154, 25);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // queryNameInput
            // 
            this.queryNameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryNameInput.Location = new System.Drawing.Point(5, 5);
            this.queryNameInput.Name = "queryNameInput";
            this.queryNameInput.Size = new System.Drawing.Size(283, 20);
            this.queryNameInput.TabIndex = 2;
            this.queryNameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QueryNameInput_KeyDown);
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainContainer.IsSplitterFixed = true;
            this.MainContainer.Location = new System.Drawing.Point(5, 0);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.queryNameInput);
            this.MainContainer.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.splitContainer2);
            this.MainContainer.Size = new System.Drawing.Size(293, 61);
            this.MainContainer.SplitterDistance = 32;
            this.MainContainer.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.OkButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.cancelButton);
            this.splitContainer2.Size = new System.Drawing.Size(293, 25);
            this.splitContainer2.SplitterDistance = 135;
            this.splitContainer2.TabIndex = 0;
            // 
            // QueryNameInputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 66);
            this.Controls.Add(this.MainContainer);
            this.Name = "QueryNameInputWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Text = "QueryName";
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel1.PerformLayout();
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox queryNameInput;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer MainContainer;
    }
}