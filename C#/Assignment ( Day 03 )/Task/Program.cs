using System;
using System.Text;

namespace Task
{
    internal class Program
    {
        // My Task Diaa Elsadek
        static void Main(string[] args)
        {

            #region Part01

            #region Problem 1

            //// Problem
            //Console.Write("Enter a number string : ");
            //string input = Console.ReadLine();

            //int num = int.Parse(input);
            //Console.WriteLine("Parsed number : " + num);

            //int num1 = Convert.ToInt32(input);
            //Console.WriteLine("Converted number : " + num1);

            //// With Try and Catch
            //try {
            //    int number1 = int.Parse(input);
            //    Console.WriteLine("Using int.Parse: " + number1);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine("int.Parse Error: " + ex.Message);
            //}

            //try {
            //    int number2 = Convert.ToInt32(input);
            //    Console.WriteLine("Using Convert: " + number2);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine("Convert Error: " + ex.Message);
            //}

            //// Question
            //// int.Parse(null) throws a ArgumentNullException, while Convert.ToInt32(null) returns 0.


            #endregion

            #region Problem 2

            //// Problem
            //Console.Write("Enter a number : ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int number)) {
            //    Console.WriteLine("Valid number: " + number);
            //}
            //else {
            //    Console.WriteLine("Invalid number format");
            //}

            //// Question
            //// Because TryParse prevents exceptions by safely checking if the input is valid, making it more user-friendly and stable.

            #endregion

            #region Problem 3

            //// Problem
            //object obj;

            //obj = 10;
            //Console.WriteLine("Int HashCode : " + obj.GetHashCode());

            //obj = "Hello";
            //Console.WriteLine("String HashCode : " + obj.GetHashCode());

            //obj = 3.14;
            //Console.WriteLine("Double HashCode : " + obj.GetHashCode());

            //// Question
            //// It provides a numeric representation of an object used in hashing algorithms and data structures like dictionaries and hash tables.

            #endregion

            #region Problem 4

            //// Problem

            //MyObject obj1 = new MyObject();
            //obj1.Value = 10;

            //MyObject obj2 = obj1;

            //obj2.Value = 20;

            //Console.WriteLine("obj1.Value: " + obj1.Value);
            //Console.WriteLine("obj2.Value: " + obj2.Value);

            //// Question
            //// It shows that multiple references can point to the same object in memory. Changing the object via one reference affects all others.

            #endregion

            #region Problem 5

            //// Problem

            //string text = "Hi";
            //Console.WriteLine("Before : " + text.GetHashCode());

            //text += " Willy";
            //Console.WriteLine("After : " + text.GetHashCode());

            //// Question
            //// Because once a string is created, it can't be changed. Any modification creates a new string to ensure performance and thread safety.

            #endregion

            #region Problem 6

            //// Problem

            //StringBuilder sb = new StringBuilder("Hi Willy");
            //Console.WriteLine("Before: " + sb.GetHashCode());

            //sb.Append("!!!");
            //Console.WriteLine("After: " + sb.GetHashCode());

            //// Question 1
            //// It modifies strings in memory without creating new ones each time, which reduces overhead and increases performance.

            //// Question 2
            //// Because it avoids memory reallocation by working with a dynamic buffer internally.

            #endregion

            #region Problem 7

            //// Problem

            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //// Concatenation
            //Console.WriteLine("Sum is : " + (num1 + num2));

            //// Composite formatting
            //Console.WriteLine(string.Format("Sum is : {0}", num1 + num2));

            //// Interpolation
            //Console.WriteLine($"Sum is : {num1 + num2}");

            //// Question
            //// String Interpolation ($"...") is most used because it’s readable, concise, and modern.

            #endregion

            #region Problem 8

            //// Problem

            //StringBuilder sb = new StringBuilder("Hello");

            //sb.Append(" World");
            //Console.WriteLine("After Append : " + sb); // Hello World

            //sb.Replace("World", "Willy");
            //Console.WriteLine("After Replace : " + sb); // Hello Willy

            //sb.Insert(0, "Hi ");
            //Console.WriteLine("After Insert : " + sb); // Hi Hello Willy

            //sb.Remove(0, 3);
            //Console.WriteLine("After Remove : " + sb); // Hello Willy

            //// Question
            //// It uses a mutable buffer, which means it doesn’t create new instances with every change, saving memory and processing time.

            #endregion

            #endregion

        }
    }
}
