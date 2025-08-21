using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem

            // 1- Create a base class Parent with properties X and Y, and a constructor to initialize them.
            // Go to the Parent.cs file

            // 2- Create a derived class Child with an additional property Z, and chain its constructor to the base class
            // Go to the Child.cs file

            // 3- Demonstrate constructor chaining by creating an instance of Child.

            Child obj1 = new Child(5, 10, 15);

            Console.WriteLine(obj1.ToString());

            Parent obj2 = new Parent(10, 20);

            Console.WriteLine(obj2.ToString());

            #endregion

            #region Question

            // Question: What is the purpose of constructor chaining in inheritance?  

            // The purpose of constructor chaining in inheritance is to ensure that
            // the base class (Parent) initializes its own fields/properties before
            // the derived class (Child) adds its own initialization. 
            // This promotes code reuse and avoids duplication.

            #endregion

        }
    }
}
