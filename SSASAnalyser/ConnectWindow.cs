using System;
using System.Windows.Forms;

namespace SSASAnalyser
{
    public partial class ConnectWindow : Form
    {
        public string connectionString;

        public ConnectWindow()
        {
            InitializeComponent();
        }

        private void DataSourceInput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void DataSourceInput_DragDrop(object sender, DragEventArgs e)
        {
            dataSourceInput.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void CatalogInput_DragDrop(object sender, DragEventArgs e)
        {
            catalogInput.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void OKButtonClick(object sender, EventArgs e)
        {            
            //If empty don't do anything
            if (String.IsNullOrEmpty(dataSourceInput.Text) || String.IsNullOrEmpty(catalogInput.Text))
            {
              return;
            }
            this.connectionString = "Data Source=" + dataSourceInput.Text + ";Catalog=" + catalogInput.Text;
            this.Close();

        }
    }
}
