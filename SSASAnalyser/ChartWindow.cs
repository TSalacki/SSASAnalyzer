using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SSASAnalyser
{
    public partial class ChartWindow : Form
    {
        Tuple<List<List<long>>, List<string>> TimesAndNamesList;

        public ChartWindow(List<List<long>> measuredTimes, List<string> queryNames)
        {
            this.TimesAndNamesList = new Tuple<List<List<long>>, List<string>>(measuredTimes, queryNames);
            InitializeComponent();
            this.ResultChart.MouseWheel += this.ResultChart_MouseWheel;
            this.UpdateChart();

        }

        private void ResultChart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (System.Windows.Forms.DataVisualization.Charting.Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 2;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 2;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 2;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 2;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        private void SaveImageMenu_Click(object sender, EventArgs e)
        {
            using (FileDialog dialog = new SaveFileDialog
            {
                Filter = "Png Files (*.png)|*.png",
                DefaultExt = "png",
                AddExtension = true
            })
            {
                dialog.ShowDialog();
                if (String.IsNullOrEmpty(dialog.FileName))
                {
                    return;
                }
                this.ResultChart.SaveImage(dialog.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            }
        }

        private void LoadChartStripMenu_Click(object sender, EventArgs e)
        {
            using (FileDialog dialog = new OpenFileDialog
            {
                Filter = "Chart files (*.ch)|*.ch",
                DefaultExt = ".ch"
            })
            {
                dialog.ShowDialog();
                if (String.IsNullOrEmpty(dialog.FileName))
                {
                    return;
                }

                System.IO.StreamReader reader = new System.IO.StreamReader(dialog.FileName);
                string jsonString = reader.ReadToEnd();
                try
                {
                    this.TimesAndNamesList = JsonConvert.DeserializeObject<Tuple<List<List<long>>, List<string>>>(jsonString);
                }
                catch (Exception exc)
                {
                    reader.Close();
                    MessageBox.Show("Error while parsing file: " + exc.Message, "Error", MessageBoxButtons.OK);
                }

                reader.Close();
                this.ResultChart.Series.Clear();
                this.SeriesButtons.Rows.Clear();
                this.TimeAnalysisGridView.Rows.Clear();
                this.UpdateChart();
            }
        }

        private void SaveTxtMenu_Click(object sender, EventArgs e)
        {
            using (FileDialog dialog = new SaveFileDialog
            {
                Filter = "Chart files (*.ch)|*.ch",
                DefaultExt = ".ch",
                AddExtension = true
            })
            {
                dialog.ShowDialog();
                if (String.IsNullOrEmpty(dialog.FileName))
                {
                    return;
                }

                System.IO.StreamWriter writer = new System.IO.StreamWriter(dialog.FileName);
                string jsonString = JsonConvert.SerializeObject(this.TimesAndNamesList);
                writer.Write(jsonString);

                writer.Close();
            }
        }

        private void UpdateChart()
        {
            this.ResultChart.Series.Clear();
            int i = 0;

            foreach (var timesList in this.TimesAndNamesList.Item1)
            {
                string seriesName = this.TimesAndNamesList.Item2[i];
                this.ResultChart.Series.Add(seriesName);
                this.ResultChart.Series[seriesName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                this.ResultChart.Series[seriesName].MarkerSize = 2;
                this.ResultChart.Series[seriesName].Enabled = true;
                
                for (int j = 0; j < timesList.Count; j++)
                {
                    this.ResultChart.Series[seriesName].Points.AddXY(j+1, timesList.ElementAt(j));
                }
                this.SeriesButtons.Rows.Add(seriesName, new DataGridViewCheckBoxCell().Value=true);

                this.TimeAnalysisGridView.Rows.Add(seriesName, this.CalculateMeanTime(timesList), Math.Round(Math.Sqrt(this.CalculateVariance(timesList)),2), Math.Round(this.CalculateVariance(timesList),2));
                i++;
            }

            this.ResultChart.ChartAreas[0].AxisX.Minimum = 1;
            this.ResultChart.ChartAreas[0].AxisX.Title = "Query no.";

            this.ResultChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            this.ResultChart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            this.ResultChart.ChartAreas[0].AxisY.Title = "Time [ms]";
            this.ResultChart.Show();
            this.SeriesButtons.Show();
        }

        private double CalculateMeanTime(List<long> timesList)
        {
            return timesList.Average();
        }

        private double CalculateVariance(List<long> timesList)
        {
            double average = timesList.Average();
            double sqDiff = timesList.Sum(d => Math.Pow(d - average, 2));
            return sqDiff / timesList.Count();
        }

        private void ChartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void SeriesButtons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                return;
            if((bool)this.SeriesButtons[e.ColumnIndex, e.RowIndex].Value)
            {
                this.SeriesButtons[e.ColumnIndex, e.RowIndex].Value = false;
                this.ResultChart.Series[(string)this.SeriesButtons[e.ColumnIndex-1, e.RowIndex].Value].Enabled = false;
                this.TimeAnalysisGridView.Rows[e.RowIndex].Visible = false;
            }
            else
            {
                this.SeriesButtons[e.ColumnIndex, e.RowIndex].Value = true;
                this.ResultChart.Series[(string)this.SeriesButtons[e.ColumnIndex-1, e.RowIndex].Value].Enabled = true;
                this.TimeAnalysisGridView.Rows[e.RowIndex].Visible = true;
            }

        }
    }
}
