using System;

namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem

            // 1- Override the ToString() method in Parent to return (X, Y) and in Child to return (X, Y, Z).
            // Go To Child.cs ( Child Class )

            // 2- Demonstrate polymorphism by printing instances of both Parent and Child. 

            Parent P1 = new Parent(1, 2);
            Console.WriteLine(P1.ToString()); // (1, 2)

            Child C1 = new Child(1, 2, 3);
            Console.WriteLine(C1.ToString()); // (1, 2, 3)

            // Polymorphism

            Parent PC = new Child(10, 20, 30);
            Console.WriteLine(PC.ToString()); // (10, 20, 30)

            #endregion

            #region Question

            // Question: Why is ToString() often overridden in custom classes?

            // ToString() is often overridden in custom classes to provide a meaningful
            // human-readable string representation of the object’s data instead of the
            // default class name output. This makes debugging, logging, and displaying
            // information easier and more useful.

            #endregion

        }
    }
}
