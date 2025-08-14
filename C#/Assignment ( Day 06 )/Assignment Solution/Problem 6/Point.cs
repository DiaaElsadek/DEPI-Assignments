using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    internal struct Point
    {
        public int X;
        public int Y;

        public Point(int _X, int _Y)
        {
            X = _X; 
            Y = _Y;
        }

        public override string ToString() {
            return $"X = {X}, Y = {Y}";
        }

    }
}
