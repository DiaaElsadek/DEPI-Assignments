using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Point1
    {

        public int X; 
        public int Y;

        // 1- A parameterized constructor initializing X to specific value and Y to 0.

        public Point1(int _X)
        {
            Y = 0;
            X = _X;
        }

        // 2- A parameterized constructor to set X and Y to specific values.

        public Point1(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }

    }
}
