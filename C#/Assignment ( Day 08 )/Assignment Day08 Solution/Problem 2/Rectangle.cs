using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    internal class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Hight { get; set; }

        public Rectangle(double W, double H)
        {
            Width = W;
            Hight = H;
        }

        public override double GetArea()
        {
            return Width * Hight;
        }
    }
}
