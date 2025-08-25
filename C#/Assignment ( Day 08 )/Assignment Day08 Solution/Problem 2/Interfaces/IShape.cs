using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Interfaces
{
    internal interface IShape
    {

        double GetArea();
        void Display()
        {
            Console.WriteLine($"Area: {GetArea()}");
        }

    }
}
