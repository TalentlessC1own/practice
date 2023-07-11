using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.Model
{ 
    public class DrawData
    {
            public DrawData(double[] xs, double[] ys)
            {
                this.xs = xs;
                this.ys = ys;
            }

            public double[] xs { get; private set; }
            public double[] ys { get; private set; }
    }
}
