using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Point
    {
        // 1- Create a struct Point with X and Y attributes
        public int X;
        public int Y;

        // 2- Add constructors: default and parameterized. 

        // Default Constructor
        public Point(int number)
        {
            X = default;
            Y = default;
        }

        // Parameterized Constructor
        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }

        // 3- Override the ToString() method to print the point as (X, Y)
        // 1- Modify the ToString() method of the Point struct to include custom formatting. [ Problem 5 ]
        public override string ToString()
        {
            return $"Point Coordinates -> X: {X}, Y: {Y}";
        }

    }
}
