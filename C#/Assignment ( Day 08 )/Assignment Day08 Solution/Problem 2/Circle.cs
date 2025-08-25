using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    internal class Circle : Shape
    {

        public double N { get; set; }

        public Circle(double _N)
        {
            N = _N;
        }

        double PI = 3.14;

        public override double GetArea()
        {
            return PI * (N*N);
        }
    }
}
