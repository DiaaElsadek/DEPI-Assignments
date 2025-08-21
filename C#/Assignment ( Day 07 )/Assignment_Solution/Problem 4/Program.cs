using Problem_3;
using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem

            // 1- Define a method Product() in the Parent class to return X * Y.

            Parent P1 = new Parent(2, 3);
            Console.WriteLine($"P1 Product : {P1.Product()}");

            Child C1 = new Child(2, 3, 4);
            Console.WriteLine($"C1 Product : {C1.Product()}");

            #endregion

            #region Question

            // Question: How does new differ from override in method overriding?  

            // The difference between new and override in method overriding is:
            // new -> hides the base class method and defines a new one in the child class.
            // override -> replaces the base class method with a new implementation in the child class.


            #endregion

        }
    }
}
