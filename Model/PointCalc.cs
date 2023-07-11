using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.Model
{
    public interface ICalculator
    {
        DrawData GetPointsData(UserData dataHolder);

    }
    public class PointCalc : ICalculator
    {
        public DrawData GetPointsData(UserData u_date)
        {
     
            List<double> x_points = new List<double>();
            List<double> y_points = new List<double>();
            for (double x = 0; x < u_date.Time; x += u_date.Step)
            {
                x_points.Add(x);
                y_points.Add(u_date.AConcentration * (1 - Math.Exp(-u_date.K * x)));
            }

            return new DrawData(x_points.ToArray(), y_points.ToArray());
        }
    }
}
