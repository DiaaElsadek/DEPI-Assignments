using Problem_2.Interfaces;
using System;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Write a program to compare Shape's abstract class with an interface-based approach. 

            // --- Abstract usage ---
            Shape Rect = new Rectangle(10, 20);

            Rect.Display();
            Console.WriteLine(Rect.GetArea());

            Shape Circ = new Circle(9.8);

            Circ.Display();
            Console.WriteLine(Circ.GetArea());


            // --- Interface usage ---

            IShape rectI = new RectangleInterface(10, 5);
            IShape circI = new CircleInterface(3);

            rectI.Display();
            Console.WriteLine("Rectangle Area: " + rectI.GetArea());

            circI.Display();
            Console.WriteLine("Circle Area: " + circI.GetArea());

        }
    }
}
