using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_02
{
    class Shape : IComparable<Shape>
    {

        public string Name { get; set; }
        public double Area { get; set; }

        public int CompareTo(Shape other)
        {
            return this.Area.CompareTo(other.Area);
        }

    }

    public class ShapeSortingDemo
    {
        public static void Run()
        {
            Shape[] shapes = new Shape[]
            {
            new Shape { Name = "Square", Area = 25 },
            new Shape { Name = "Circle", Area = 78.5 },
            new Shape { Name = "Rectangle", Area = 50 },
            new Shape { Name = "Triangle", Area = 12.5 }
            };

            Array.Sort(shapes);

            Console.WriteLine("\nShapes sorted by area:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.Name} - Area: {shape.Area}");
            }
        }
    }

}
