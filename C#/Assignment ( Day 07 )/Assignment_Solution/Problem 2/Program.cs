using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem

            // Write a class Calculator with overloaded Sum() methods to:

            // 1. Add two integers. 
            // 2. Add three integers. 
            // 3. Add two doubles. 

            // Write a program to test each overload.

            Calculator calc = new Calculator();

            // Test 1 => Add two integers

            int result1 = calc.Sum(10, 20);
            Console.WriteLine("Sum of two integers (10 + 20) = " + result1);

            // Test 2: Add three integers
            int result2 = calc.Sum(5, 15, 25);
            Console.WriteLine("Sum of three integers (5 + 15 + 25) = " + result2);

            // Test 3: Add two doubles
            double result3 = calc.Sum(12.5, 5.3);
            Console.WriteLine("Sum of two doubles (12.5 + 5.3) = " + result3);

            #endregion


            #region Question

            // Question: How does method overloading improve code readability and reusability?  

            // Method overloading improves code readability and reusability because:
            // - It allows using the same method name (e.g., Sum) for related operations,
            //   instead of creating multiple different names (like SumInt, SumDouble).
            // - This makes the code easier to read and understand, since the intent is clear.
            // - It also increases reusability by handling different parameter types or counts
            //   without duplicating logic under new method names.

            #endregion

        }
    }
}
