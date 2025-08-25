using Problem_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    internal class Circle : IShape
    {
        public double Area { get; }

        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
