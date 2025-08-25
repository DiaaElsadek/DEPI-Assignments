using Problem_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    internal class Rectangle : IShape
    {
        public double Area { get; }

        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
