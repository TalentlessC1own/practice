using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.Model
{
    public class UserData
    {
        public UserData(double AConcentration, double K, double Time, double Step)
        {
            this.AConcentration = AConcentration;
            this.K = K;
            this.Time = Time;
            this.Step = Step;
        }

        public  double AConcentration {  get;  private set; }
        public double K { get; private set; }
        public double Time { get; private set; }
        public double Step { get; private set; }
        public string GetStringData()
        {
            return $"{AConcentration} {K} {Time} {Step}";
        }
    }
}
