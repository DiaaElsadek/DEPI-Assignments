using System;

namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem

            // 3- Demonstrate the usage with objects of Rectangle. 

            Shape Rect1 = new Rectangle(10.5, 20.0);

            Rect1.Draw();

            Console.WriteLine($"Area = {Rect1.CalculateArea()}");

            #endregion

            #region Question

            // Question: What is the difference between a virtual method and an abstract method in C#?

            // In C#, a virtual method provides a default implementation in the base class, 
            // and derived classes may override it if needed. 
            // An abstract method, on the other hand, has no implementation in the base class 
            // and must be overridden in any non-abstract derived class.

            #endregion

        }
    }
}
