using System;
using System.Windows.Forms;

namespace SSASAnalyser
{
    public partial class QueryNameInputWindow : Form
    {
        public string queryName;
        
        public QueryNameInputWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.queryName = this.queryNameInput.Text.Trim();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void QueryNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.OkButton_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.CancelButton_Click(sender, e);
            }
        }
    }
}
