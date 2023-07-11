using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using practice.Model;

namespace practice
{
    public interface IMainForm
    {
        string AConcentration { get; set; }
        string K { get; set; }
        string Time { get; set; }
        string Step { get; set; }
        string[] TimeMassive{ get; set; }
        string[] AConcentrationMassive { get; set; }

        void ModelChartDraw(DrawData drawData);
        void ExperimentChartDraw(DrawData drawData);
         void ClearDataGrid();

        Image Image { get; }
        void ModelChartClear();
        void ExperimentChartClear();
        event EventHandler ModelChartTryDraw;
        event EventHandler ExperimentTryDraw;
        event EventHandler ModelChartDataClear;
        event EventHandler ExperimentChartDataClear;
        event EventHandler TryAnal;
        event EventHandler OpenFileData;
        event EventHandler SaveData;
        event EventHandler ShowGreatings;
    }
    public partial class Form1 : Form, IMainForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string AConcentration
        {
            get { return CAtextBox.Text; }
            set
            {
                CAtextBox.Text = value;
                this.Refresh();
            }
        }
        public string K
        {
            get { return KtextBox.Text; }
            set
            {
                KtextBox.Text = value;
                this.Refresh();
            }
        }
        public string Time
        {
            get { return TtextBox.Text; }
            set
            {
                TtextBox.Text = value;
                this.Refresh();
            }
        }
        public string Step
        {
            get
            {
                return StepTextBox.Text;
            }
            set
            {
                StepTextBox.Text = value;
                this.Refresh();
            }
        }

        public string MeError
        {
            get
            {
                return meError.Text;
            }
            set
            {
                meError.Text = value;
                this.Refresh();
            }
        }
        public string[] TimeMassive
        {
            get
            {
                List<string> t_massive=new List<string>();
                for (int rows = 0; rows < experimentDataGridView.Rows.Count - 1; rows++)
                {
                  
                        t_massive.Add(experimentDataGridView.Rows[rows].Cells[0].Value.ToString());
                    
                }
                return t_massive.ToArray();
            }
            set
            {
                this.Refresh();
            }
        }
        public string[] AConcentrationMassive
        {
            get
            {
                List<string> t_massive = new List<string>();
                for (int rows = 0; rows < experimentDataGridView.Rows.Count - 1; rows++)
                {

                    t_massive.Add(experimentDataGridView.Rows[rows].Cells[1].Value.ToString());

                }
                return t_massive.ToArray();
            }
            set
            {
                this.Refresh();
            }
        }
        public string FilePath => throw new NotImplementedException();
        public Image Image => throw new NotImplementedException();


        public event EventHandler ModelChartTryDraw;
        public event EventHandler ExperimentTryDraw;
        public event EventHandler ModelChartDataClear;
        public event EventHandler ExperimentChartDataClear;
        public event EventHandler TryAnal;
        public event EventHandler OpenFileData;
        public event EventHandler SaveData;
        public event EventHandler ShowGreatings;

 

        public void ExperimentChartDraw(DrawData drawData)
        {
            for (int i = 0; i < drawData.xs.Length; i++)
            {
                ExperimentChart.Series[0].Points.AddXY(drawData.xs[i], drawData.ys[i]);
                ExperimentChart.Series[1].Points.AddXY(drawData.xs[i], drawData.ys[i]);
            }
        }

        public void ClearDataGrid()
        {
            experimentDataGridView.Rows.Clear();
        }

        public void ModelChartDraw(DrawData drawData)
        {
            for (int i = 0; i < drawData.xs.Length; i++)
            {
                ModelChart.Series[0].Points.AddXY(drawData.xs[i], drawData.ys[i]);
                ModelChart.Series[1].Points.AddXY(drawData.xs[i], drawData.ys[i]);
            }
        }

        public void ExperimentChartClear()
        { 
            foreach (var series in ExperimentChart.Series)
            {
                series.Points.Clear();
            }
        }

        public void ModelChartClear()
        {
            foreach (var series in ModelChart.Series)
            {
                series.Points.Clear();
            }

        }

        private void tryFirstDrawButton_Click(object sender, EventArgs e)
        {
            if (ModelChartTryDraw != null) ModelChartTryDraw(this, EventArgs.Empty);
        }

        private void TryDrawExperimentButton_Click(object sender, EventArgs e)
        {
            if (ExperimentTryDraw != null) ExperimentTryDraw(this, EventArgs.Empty);
        }

        private void ClearModelChartButton_Click(object sender, EventArgs e)
        {
            if (ModelChartDataClear != null) ModelChartDataClear(this, EventArgs.Empty);
        }

        private void ClearExperimentChartButton_Click(object sender, EventArgs e)
        {
            if (ExperimentChartDataClear != null) ExperimentChartDataClear(this, EventArgs.Empty);
        }

        private void StepTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            TryAnal?.Invoke(this, EventArgs.Empty);
        }
    }
}
