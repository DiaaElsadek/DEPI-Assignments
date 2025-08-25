using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Interfaces
{
    internal interface IShape
    {

        public double Area { get; }

        public void Draw();

        public void PrintDetailds()
        {
            Console.WriteLine($"I am a shape and my Area is {Area}");
        }

    }
}
