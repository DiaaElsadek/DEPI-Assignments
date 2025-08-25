using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Interfaces
{
    internal class RectangleInterface : IShape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public RectangleInterface(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public void Display()
        {
            Console.WriteLine("This is a rectangle (interface-based)");
        }

    }
}
