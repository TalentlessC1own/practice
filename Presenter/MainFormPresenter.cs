using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Accord.Math.Distances;
using practice.Model;
using MathNet.Numerics;
using MathNet.Numerics.Statistics;

namespace practice.Presenter
{
    public class MainFormPresenter
    {

        private readonly IMainForm mainForm;
        private readonly ICalculator calculator;
        private readonly IMessageService messageService;
        private readonly IValidator validator;
        private readonly IFileManager fileManager;

        public MainFormPresenter(IMainForm mainForm, ICalculator calculator, IMessageService messageService,
            IValidator validator, IFileManager fileManager)
        {
            this.mainForm = mainForm;
            this.calculator = calculator;
            this.messageService = messageService;
            this.validator = validator;
            this.fileManager = fileManager;
            this.fileManager = fileManager;


            mainForm.ModelChartTryDraw += new EventHandler(MainForm_TryModelChartDraw);
            mainForm.ExperimentTryDraw += new EventHandler(MainForm_TryExperimentChartDraw);
            mainForm.ModelChartDataClear += new EventHandler(MainForm_ModelChartClear);
            mainForm.ExperimentChartDataClear += new EventHandler(MainForm_ExperimentChartClear);
            mainForm.TryAnal += MainForm_TryAnal;

        }

        private void MainForm_TryAnal(object sender, EventArgs e)
        {
            Anal();
        }

        private void MainForm_TryModelChartDraw(object sender, EventArgs e)
        {

            UserData user_data = new UserData(double.Parse(mainForm.AConcentration),
                double.Parse(mainForm.K), double.Parse(mainForm.Time), double.Parse(mainForm.Step));
            DrawData draw_data = calculator.GetPointsData(user_data);

            mainForm.ModelChartDraw(draw_data);


        }

        private void MainForm_TryExperimentChartDraw(object sender, EventArgs e)
        {
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();
            for (int i = 0; i < mainForm.TimeMassive.Length; i++)
            {
                xs.Add(double.Parse(mainForm.TimeMassive[i]));
                ys.Add(double.Parse(mainForm.AConcentrationMassive[i]));
            }

            DrawData draw_data = new DrawData(xs.ToArray(), ys.ToArray());

            mainForm.ExperimentChartDraw(draw_data);
        }

        void MainForm_ModelChartClear(object sender, EventArgs e)
        {
            mainForm.AConcentration = "";
            mainForm.K = "";
            mainForm.Time = "";
            mainForm.Step = "";
            mainForm.ModelChartClear();
        }

        private void MainForm_ExperimentChartClear(object sender, EventArgs e)
        {

            mainForm.ExperimentChartClear();
            mainForm.ClearDataGrid();
        }

        public void Anal()
        {
            List<double> concentrations = new List<double>();
            List<double> times = new List<double>();

            for (int i = 0; i < mainForm.TimeMassive.Length; i++)
            {
                times.Add(double.Parse(mainForm.TimeMassive[i]));
                concentrations.Add(double.Parse(mainForm.AConcentrationMassive[i]));
            }
            List<double> velocities = new List<double>();
            for (int i = 0; i < concentrations.Count; i++)
            {
                double A_t = concentrations[i];
                double t = times[i];
                double v = -Math.Log(A_t ) / t;
                velocities.Add(v);
            }

            double[] logConcentrations = concentrations.Select(c => Math.Log(c)).ToArray();
            double[] timesArray = times.ToArray();

            PearsonCorrelation q = new PearsonCorrelation();
          

            double r = Correlation.Pearson(timesArray, logConcentrations);

            if (Math.Abs(r) < 0.98)
            {
                messageService.ShowMessage("Реакция не  является реакцией первого порядка.");
            }
            else
            {
                messageService.ShowMessage("Реакция   является реакцией первого порядка.");

            }

        }

    }
}


