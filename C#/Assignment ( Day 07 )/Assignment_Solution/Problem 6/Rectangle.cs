using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    internal class Rectangle : Shape
    {

        public double H {  get; set; }
        public double W { get; set; }

        public Rectangle(double _H, double _W)
        {
            H = _H;
            W = _W;
        }

        // Create a derived class Rectangle overriding Draw() and implementing CalculateArea().

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        // Implement the abstract method CalculateArea()
        public override double CalculateArea()
        {
            return H * W;
        }

    }
}
