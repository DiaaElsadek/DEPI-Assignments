using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    internal abstract class Shape
    {

        public abstract double GetArea();

        public void Display()
        {
            Console.WriteLine($"Area: {GetArea()}");
        }

    }
}
