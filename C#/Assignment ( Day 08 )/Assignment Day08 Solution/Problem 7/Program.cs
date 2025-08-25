using System;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program to demonstrate constructor overloading. 

            Book B1 = new Book();

            Console.WriteLine(B1);

            Book B2 = new Book("Book 2");

            Console.WriteLine(B2);

            Book B3 = new Book("Book 3", "Autor 3");

            Console.WriteLine(B3);

            #region Question

            // Question: How does constructor overloading improve class usability?  

            // Constructor overloading allows creating objects in different ways,
            // making the class more flexible and easier to use.

            #endregion

        }
    }
}
