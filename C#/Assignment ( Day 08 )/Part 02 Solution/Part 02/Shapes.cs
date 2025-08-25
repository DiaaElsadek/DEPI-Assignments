using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_02
{

    public abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        public abstract double CalculateArea();
        public abstract double Perimeter { get; }
    }
    class Triangle : GeometricShape
    {

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return Dimension1 + Dimension2 + Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2); }
        }

    }

    public class Rectangle : GeometricShape
    {
        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return 2 * (Dimension1 + Dimension2); }
        }
    }

    public class GeometricShapeDemo
    {
        public static void Run()
        {
            Rectangle rect = new Rectangle { Dimension1 = 5, Dimension2 = 10 };
            Triangle tri = new Triangle { Dimension1 = 3, Dimension2 = 4 };

            Console.WriteLine($"\nRectangle Area: {rect.CalculateArea()}, Perimeter: {rect.Perimeter}");
            Console.WriteLine($"Triangle Area: {tri.CalculateArea()}, Perimeter: {tri.Perimeter}");
        }
    }

}
