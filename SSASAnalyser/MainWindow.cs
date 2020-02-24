using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace SSASAnalyser
{
    public partial class MainWindow : Form
    {
        readonly Model model;
        readonly BackgroundWorker backgroundQuerryWorker;
        readonly QueryModel queryModel;

        public MainWindow(Model model, QueryModel queryModel)
        {
            this.model = model;
            this.queryModel = queryModel;
            this.backgroundQuerryWorker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true,
                WorkerReportsProgress = true
            };
            this.model.ReadyToDisplayChart += DisplayChart;
            this.backgroundQuerryWorker.DoWork += BackgroundQuerryWorker_DoWork;
            this.backgroundQuerryWorker.ProgressChanged += BackgroundQuerryWorker_ProgressChanged;
            this.backgroundQuerryWorker.RunWorkerCompleted += BackgroundQuerryWorker_RunWorkerCompleted;
            InitializeComponent();
            foreach (var tuple in this.queryModel.Queries)
            {
                this.QuerySelectionList.Items.Add(tuple.Item1);
            }
            this.disconnectToolStripMenuItem.Enabled = false;
            this.ClearCacheNowButton.Enabled = false;
            this.QuerySelectionList.SelectedItem = this.QuerySelectionList.Items[0];
        }

        private void DisplayChart(object sender, EventArgs e)
        {
            ChartWindow chartForm = new ChartWindow(model.QueryExecutionTimes, queryModel.GetQueryNames());
            this.Invoke((MethodInvoker)(() => chartForm.ShowDialog()));
        }

        private void BackgroundQuerryWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(this.queryModel.CurrentQueryIndex < this.queryModel.Queries.Count-1 && !e.Cancelled)
            {
                this.queryModel.CurrentQueryIndex++;
                this.completitionProgressBar.Value = 0;
                this.repetitionsNumberCounter.Clear();
                this.repetitionsNumberInput.Text = this.queryModel.Queries[this.queryModel.CurrentQueryIndex].Item3.ToString();
                this.completitionProgressBar.Maximum = this.queryModel.Queries[this.queryModel.CurrentQueryIndex].Item3;
                this.QuerySelectionList.SelectedIndex = this.queryModel.CurrentQueryIndex;
              
                this.backgroundQuerryWorker.RunWorkerAsync();
                return;
            }else if (e.Cancelled)
            {
                this.completitionProgressBar.Value = 0;
                this.repetitionsNumberCounter.Clear();
                if (this.model.Srv.SessionTrace.IsStarted)
                    this.model.Srv.SessionTrace.Stop();
            }
            this.runButton.Text = "Run";
            this.queryModel.CurrentQueryIndex = 0;
            this.EnableDown();
        }

        private void BackgroundQuerryWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.repetitionsNumberCounter.Text = (e.ProgressPercentage + 1).ToString();
            this.repetitionsNumberCounter.Update();
            this.completitionProgressBar.Value++;
        }

        private void BackgroundQuerryWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (!this.model.Srv.SessionTrace.IsStarted)
                this.model.Srv.SessionTrace.Start();
            if (this.model.ConnectionState != SSASConnectionState.CLOSED)
            {
                for (int i = 0; i < this.queryModel.Queries[this.queryModel.CurrentQueryIndex].Item3; i++)
                {
                    try
                    {
                        model.RunQuerry(this.queryModel.Queries[this.queryModel.CurrentQueryIndex].Item2);
                        worker.ReportProgress(i);
                    }catch(Exception exc)
                    {
                        MessageBox.Show("Error while executing query: " + exc.Message, "Error", MessageBoxButtons.OK);
                        e.Cancel = true;
                        return;
                    }
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void RunQueryPlanButtonClick(object sender, EventArgs e)
        {
            if (!this.backgroundQuerryWorker.IsBusy)
            {
                this.DisableDown();
                this.runButton.EnableUp();
                
                this.runButton.Text = "Stop";

                this.QuerySelectionList.SelectedItem = this.QuerySelectionList.Items[0];
                this.model.RepetitionsToDoList.Clear();
                this.model.QueryExecutionTimes.Clear();
                this.model.QueryExecutionTimes.Add(new System.Collections.Generic.List<long>());
                foreach (var queryTuple in this.queryModel.Queries)
                {
                    this.model.RepetitionsToDoList.Add(queryTuple.Item3);
                }
                this.repetitionsNumberCounter.Text = "0";
                this.completitionProgressBar.Value = 0;
                this.completitionProgressBar.Maximum = model.RepetitionsToDoList[0];

                this.backgroundQuerryWorker.RunWorkerAsync();
            }
            else
            {
                this.backgroundQuerryWorker.CancelAsync();
            }
        }
        
        private void ConnectToMultidimensionalMenuItem_Click(object sender, EventArgs e)
        {
            if (this.model.ConnectionState != SSASConnectionState.CLOSED)
                return;
            else
            {
                using (ConnectWindow inputMenu = new ConnectWindow())
                {
                    inputMenu.ShowDialog();
                    if (String.IsNullOrEmpty(inputMenu.connectionString))
                    {
                        return;
                    }
                    try
                    {
                        this.model.MakeConnection(inputMenu.connectionString, SSASConnectionState.MULTIDIMENSIONAL);
                        this.completitionProgressBar.Value = 0;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error while connecting: " + exc.Message, "Error", MessageBoxButtons.OK);
                        return;
                    }

                    this.MultidimensionalConnectionStatus.BackColor = Color.Green;
                    this.ClearCacheNowButton.Enabled = true;
                    this.runButton.Enabled = true;
                    this.disconnectToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void ConnectToTabularMenuItem_Click(object sender, EventArgs e)
        {
            if (this.model.ConnectionState != SSASConnectionState.CLOSED)
                return;
            else
            {
                using (ConnectWindow inputMenu = new ConnectWindow())
                {
                    inputMenu.ShowDialog();
                    if (String.IsNullOrEmpty(inputMenu.connectionString))
                    {
                        return;
                    }
                    try
                    {
                        this.model.MakeConnection(inputMenu.connectionString, SSASConnectionState.TABULAR);
                        this.completitionProgressBar.Value = 0;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Error while connecting: " + exc.Message, "Error", MessageBoxButtons.OK);
                        return;
                    }

                    this.TabularConnectionStatus.BackColor = Color.Green;
                    this.ClearCacheNowButton.Enabled = true;
                    this.runButton.Enabled = true;
                    this.disconnectToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.model.SSASConnection.Close();
            if (this.model.ConnectionState == SSASConnectionState.MULTIDIMENSIONAL)
            {
                this.MultidimensionalConnectionStatus.BackColor = Color.Red;
            }else if(this.model.ConnectionState == SSASConnectionState.TABULAR)
            {
                this.TabularConnectionStatus.BackColor = Color.Red;
            }
            this.model.ConnectionState = SSASConnectionState.CLOSED;
            this.model.Srv.Disconnect();
            this.runButton.Enabled = false;
            this.ClearCacheNowButton.Enabled = false;
            this.completitionProgressBar.Value = 0;
            this.disconnectToolStripMenuItem.Enabled = false;
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.model.CacheClearing = true;
            this.dontClearCacheOption.BackColor = SystemColors.Control;
            this.clearCacheOption.BackColor = SystemColors.MenuHighlight;
        }

        private void DontClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.model.CacheClearing = false;
            this.dontClearCacheOption.BackColor = SystemColors.MenuHighlight;
            this.clearCacheOption.BackColor = SystemColors.Control;
        }

        private void QueryBox_DragDrop(object sender, DragEventArgs e)
        {
            this.queryInputBox.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void QueryBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void RepetitionsInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartWindow chartForm = new ChartWindow(model.QueryExecutionTimes, queryModel.GetQueryNames());
            chartForm.ShowDialog();
        }

        private void ClearToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.model.QueryExecutionTimes.Clear();
        }

        private void SaveQueryPlanMenuItem_Click(object sender, EventArgs e)
        {
            using (FileDialog dialog = new SaveFileDialog
            {
                Filter = "Query Plan Files (*.qp)|*.qp",
                DefaultExt = ".qp",
                AddExtension = true
            })
            {
                dialog.ShowDialog();
                if (String.IsNullOrEmpty(dialog.FileName))
                {
                    return;
                }

                this.queryModel.SaveQueryListToFile(dialog.FileName);
            }
        }

        private void LoadQueryPlanMenuItem_Click(object sender, EventArgs e)
        {
            using (FileDialog dialog = new OpenFileDialog
            {
                Filter = "Query Plan Files (*.qp)|*.qp",
                DefaultExt = ".qp",
            })
            {
                dialog.ShowDialog();
                if (String.IsNullOrEmpty(dialog.FileName))
                {
                    return;
                }

                try
                {
                    this.queryModel.LoadQueryListFromFile(dialog.FileName);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error while parsing file: " + exc.Message, "Error", MessageBoxButtons.OK);
                    return;
                }

                this.QuerySelectionList.Items.Clear();
                this.queryInputBox.Text = this.queryModel.Queries[0].Item2;
                this.repetitionsNumberInput.Text = this.queryModel.Queries[0].Item3.ToString();
                foreach (var tuple in this.queryModel.Queries)
                {
                    this.QuerySelectionList.Items.Add(tuple.Item1);
                }
                this.QuerySelectionList.SelectedIndex = 0;
            }
        }

        private void ClearNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.model.ClearCache();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error while clearing cache: " + exc.Message, "Error", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Cache Cleared", "Info", MessageBoxButtons.OK);
        }

        private void AddQueryButton_Click(object sender, EventArgs e)
        {
            using (QueryNameInputWindow queryDialog = new QueryNameInputWindow())
            {
                queryDialog.ShowDialog();
                if (queryDialog.IsDisposed || String.IsNullOrEmpty(queryDialog.queryName) || this.queryModel.FindQueryByTitle(queryDialog.queryName) != null)
                {
                    return;
                }

                this.queryModel.Queries.Add(new Tuple<string, string, int>(queryDialog.queryName, "", 1));
                this.QuerySelectionList.Items.Add(queryDialog.queryName);
                this.QuerySelectionList.SelectedItem = queryDialog.queryName;
            }
        }

        private void RenameQueryButton_Click(object sender, EventArgs e)
        {
            using (QueryNameInputWindow queryDialog = new QueryNameInputWindow())
            {
                queryDialog.ShowDialog();
                if (queryDialog.IsDisposed || String.IsNullOrEmpty(queryDialog.queryName))
                {
                    return;
                }
                else
                {
                    var query = this.queryModel.FindQueryByTitle(this.QuerySelectionList.SelectedItem.ToString());
                    this.queryModel.EditQueryByTitle(this.QuerySelectionList.SelectedItem.ToString(), queryDialog.queryName, query.Item2, query.Item3);
                    int index = this.QuerySelectionList.Items.IndexOf(this.QuerySelectionList.SelectedItem);
                    this.QuerySelectionList.Items.Insert(index, queryDialog.queryName);
                    this.QuerySelectionList.SelectedItem = queryDialog.queryName;
                    this.QuerySelectionList.Items.RemoveAt(index + 1);
                }
            }
        }

        private void RemoveQueryButton_Click(object sender, EventArgs e)
        {
            if (this.queryModel.Queries.Count == 1)
                return;

            int index = this.QuerySelectionList.Items.IndexOf(this.QuerySelectionList.SelectedItem);
            string oldSelectedItem = this.QuerySelectionList.SelectedItem.ToString();
            this.queryModel.RemoveQueryByTitle(this.QuerySelectionList.SelectedItem.ToString());
            if (index != 0) 
            {
                this.QuerySelectionList.SelectedItem = this.QuerySelectionList.Items[0];
            }
            else
            {
                this.QuerySelectionList.SelectedItem = this.QuerySelectionList.Items[1];
            }
                
            this.QuerySelectionList.Items.Remove(oldSelectedItem);

            var tuple = this.queryModel.FindQueryByTitle(this.QuerySelectionList.SelectedItem.ToString());
            this.repetitionsNumberInput.Text = tuple.Item3.ToString();
            this.queryInputBox.Text = tuple.Item2.ToString();
        }

        private void SaveQueryButton_Click(object sender, EventArgs e)
        {
            this.queryModel.EditQueryByTitle(this.QuerySelectionList.SelectedItem.ToString(), this.QuerySelectionList.SelectedItem.ToString(), this.queryInputBox.Text, int.Parse(this.repetitionsNumberInput.Text));
        }

        private void QueryList_SelectedValueChanged(object sender, EventArgs e)
        {
            var tuple = this.queryModel.FindQueryByTitle(this.QuerySelectionList.SelectedItem.ToString());
            if (tuple == null)
                return;
            this.repetitionsNumberInput.Text = tuple.Item3.ToString();
            this.queryInputBox.Text = tuple.Item2.ToString();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.model.SSASConnection.Close();
            this.model.Srv.Disconnect();
            this.backgroundQuerryWorker.Dispose();
            this.Dispose();
        }
    }
}
