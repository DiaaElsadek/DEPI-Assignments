using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    internal abstract class Shape
    {

        // 1- A virtual method Draw() that prints "Drawing Shape".
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        // 2- An abstract method CalculateArea() for area calculation. 

        public abstract double CalculateArea();

    }
}
