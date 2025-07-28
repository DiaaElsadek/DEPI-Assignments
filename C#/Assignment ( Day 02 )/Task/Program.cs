using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Threading.Tasks;
// My Task
namespace Task
{
    class Program
    {
        static void Main()
        {
            #region Part01

            #region Problem 1
            //// Problem: Add both single-line and multi-line comments in the following code segment explaining its purpose:
            //int x = 10; // decare an integer variable x and assign it the value 10
            //int y = 20; // declare an integer variable y and assign it the value 20
            //int sum = x + y; // decalre an integer variable sum and assign it the sum of x and y
            //Console.WriteLine(sum); // print the value of sum to the console
            ///*
            //    This is a small program that calculates the sum of two integers
            //    first line declares an integer variable x and assigns it the value 10
            //    second line declares an integer variable y and assigns it the value 20
            //    third line declares an integer variable sum and assigns it the sum of x and y
            //    fourth line prints the value of sum to the console
            //    thats a simple program that demonstrates the use of variables and arithmetic operations in C#
            //*/
            #endregion

            #region Problem 2
            // Question: What is the shortcut to comment and uncomment a selected block of code in Visual Studio ?
            // To comment a block of code is ctrl + K + C
            // To uncomment a block of code is ctrl + K + U
            #endregion

            #region Problem 3
            //// Problem: Identify and fix the errors in this code snippet:
            //// int x = "10";
            //// The error is that we are trying to assign a string value to an integer variable.
            //// console.WriteLine(x + y);
            //// The error is that we are trying to use a method that does not exist. The correct method is Console.WriteLine. And we hould declare y before using it and convert x to int.
            //int x = 10; // declare an integer variable x and assign it the value 10
            //int y = 20; // declare an integer variable y and assign it the value 20
            //Console.WriteLine(x + y); // print the sum of x and y to the console
            #endregion

            #region Problem 4
            //// Question: Explain the difference between a runtime error and a logical error with examples
            //// 1 - Runtime Error
            //// A runtime error is an error that occurs while the program is running, such as trying to divide by zero or accessing an index that is out of bounds
            //int a = 10;
            //int b = 0;
            //int result = a / b;  // Runtime Error: Divide By Zero Exception
            //Console.WriteLine(result);

            //// 2 - Logical Error
            //// A logical error is an error that occurs when the program runs without crashing, but produces incorrect results due to a mistake in the logic of the code
            //int x = 10;
            //int y = 5;
            //int result1 = x - y;  // Logical Error: It should be a + b
            //Console.WriteLine("Sum is: " + result1);

            //// 3 - Syntax Error
            //// A syntax error is an error that occurs when the code does not follow the correct syntax of the programming language, such as missing a semicolon or using an incorrect keyword
            //int x = 10  // Syntax Error: Missing semicolon
            //Console.WriteLine(x);

            //// 4 - Compilation Error
            //// A compilation error is an error that occurs when the code cannot be compiled due to a syntax error or a missing reference
            //// For example, if we try to use a class that is not defined or imported, we will get a compilation error

            //// 5 - Warning
            //// A warning is a message that indicates a potential issue in the code, such as using a deprecated method or variable that is never used
            //// For example, if we use a method that is marked as obsolete, we will get a warning message

            //// 6 - Exception
            //// An exception is an error that occurs during the execution of the program, such as trying to access a null reference or an invalid index in an array
            //// For example, if we try to access an element in an array that is out of bounds, we will get an exception

            //// 7 - Semantic Error
            //// A semantic error is an error that occurs when the code is syntactically correct but does not produce the expected results due to a mistake in the meaning of the code
            //int x = "hello";  // Semantic Error: Can't assign string to int

            //// 8 - Type Error
            //// A type error is an error that occurs when we try to use a value of one type in a context that requires a different type
            //// For example, if we try to add a string to an integer, we will get a type error

            //// 9 - Null Reference Error
            //// A null reference error is an error that occurs when we try to access a member of an object that is null
            //// For example, if we try to call a method on a null object, we will get a null reference error
            #endregion

            #region Problem 5
            //// Problem: Declare variables using proper naming conventions to store:
            //// Your full name. 
            //// Your age.
            //// Your monthly salary.
            //// Whether you are a student.

            //string FullName = "Diaa Elsadek";
            //int Age = 20;
            //double MonthlySalary = 7500.50;
            //bool IsStudent = true;
            #endregion

            #region Problem 6
            //// Question: Why is it important to follow naming conventions such as PascalCase in C#? 
            //// Answer: Following naming conventions like PascalCase in C# is important because it improves code readability, ensures consistency, facilitates team collaboration, reduces bugs, and aligns with official Microsoft standards.
            #endregion

            #region Problem 7
            //// Problem: Write a program to demonstrate that changing the value of a reference type affects all references pointing to that object.
            //Point P1 = new Point(); // Declare a reference type variable P1 of type Point and allocate memory for it
            //P1.x = 10; // Assign the value 10 to the x property of P1
            //P1.y = 20; // Assign the value 20 to the y property of P1
            //Console.WriteLine(P1.x); // Print the value of the x property of P1, which will be 10
            //Console.WriteLine(P1.y); // Print the value of the y property of P1, which will be 20
            //Point P2 = P1; // Declare another reference type variable P2 and assign it the same reference as P1
            //P2.x = 30; // Change the value of the x property of P2 to 30
            //P2.y = 40; // Change the value of the y property of P2 to 40
            //Console.WriteLine(P1.x); // Print the value of the x property of P1, which will be 30
            //Console.WriteLine(P1.y); // Print the value of the y property of P1, which will be 40
            #endregion

            #region Problem 8
            // Question: Explain the difference between value types and reference types in terms of memor allocation

            // Value types are stored in the stack.
            // Each variable has its own independent copy of the data.
            // So changes to one value type variable do NOT affect the other.

            // Reference types are stored in the heap.
            // Variables store a reference (pointer) to the actual object in memory.
            // So changes made through one reference affect all references to the same object.
            #endregion

            #region Problem 9
            //// Problem: Create a program that calculates the following using variables x = 15 and y = 4
            //int x = 15; // Declare an integer variable x and assign it the value 15
            //int y = 4; // Declare an integer variable y and assign it the value 4

            //// 1 - Sum
            //int sum = x + y; // Calculate the sum of x and y
            //Console.WriteLine("Sum: " + sum); // Print the sum to the console

            //// 2 - Difference
            //int difference = x - y; // Calculate the difference between x and y
            //Console.WriteLine("Difference: " + difference); // Print the difference to the console

            //// 3 - Product
            //int product = x * y; // Calculate the product of x and y
            //Console.WriteLine("Product: " + product); // Print the product to the console

            //// 4 - Division result
            //double divisionResult = (double)x / y; // Calculate the division result of x by y and cast to double for precision
            //Console.WriteLine("Division Result: " + divisionResult); // Print the division result to the console

            //// 5 - Remainder
            //int remainder = x % y; // Calculate the remainder of x divided by y
            //Console.WriteLine("Remainder: " + remainder); // Print the remainder to the console

            #endregion

            #region Problem 10
            // Question: What will be the output of the following code? Explain why:
            // int a = 2, b = 7;
            // Console.WriteLine(a % b);
            // output: 2
            // output is 2 because the modulus operator (%) returns the remainder of the division of a by b. In this case, 2 divided by 7 gives a quotient of 0 and a remainder of 2.
            #endregion

            #region Problem 11
            //// Problem: Write a program that checks if a given number is both:
            //// 1 - Greate than 10
            //// 2 - Even

            //Console.Write("Enter your number : ");
            //int number = int.Parse(Console.ReadLine());

            //if (number > 10 && number % 2 == 0)
            //{
            //    Console.WriteLine("The number is greater than 10 and even");
            //}
            //else
            //{
            //    if (number % 2 == 0){
            //        Console.WriteLine("The Number is less than or equal 10");
            //    }
            //    else{
            //        Console.WriteLine("The number is greate than 10 but is odd number");
            //    }
            //}

            #endregion

            #region Problem 12
            //// Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator?
            //// The diffrence between && (logical AND) and & (butwise AND) is :
            //// 1 - && (logical AND)
            //// Works only with boolean values, Performs short-circuit evaluation, Commonly used in if statements for better performance
            //// Example
            //int a = 5, b = 10;
            //if (a > 3 && b < 20)
            //{
            //    Console.WriteLine("Both conditions are true");
            //}

            //// 2 - & (bitwise AND)
            //// Works with Integers performs bitwise AND and Booleans performs logical AND, but no short-circuiting
            //// Always evaluates both operands, even if the first is false
            //// Example
            //int x = 6;  // Binary : 110
            //int y = 3;  // Binary : 011
            //int result = x & y;  // Result : 010 -> 2
            #endregion

            #region Problem 13
            //// Problem: Implement a program that takes a double input from the user and casts it to an int. Use both implicit and explicit casting, then print the results. 
            //Console.WriteLine("Enter the double number : ");
            //double DoubleValue = double.Parse(Console.ReadLine());

            //int Value = (int)DoubleValue; // Convert double to int

            //double DoubleValue1 = Value;

            //// input : 20.42

            //Console.WriteLine(DoubleValue); // 20.42
            //Console.WriteLine(Value); // 20
            //Console.WriteLine(DoubleValue1); // 20
            #endregion

            #region Problem 14
            // Question: Why is explicit casting required when converting a double to an int? 
            // because the conversion is narrowing meaning there is a risk of data loss.
            // Example :
            // When you convert 10.20 to int number we cant take .20 for the int value we just need 10 value
            #endregion

            #region Problem 15
            //Console.WriteLine("enter your age : ");
            //string age = Console.ReadLine(); // prompts
            //int agevalue = int.Parse(age); // convert
            //// check if age is valid or invalid
            //if (agevalue > 0)
            //{
            //    Console.WriteLine("your age is valid");
            //}
            //else
            //{
            //    Console.WriteLine("your age is invalid");
            //}
            #endregion

            #region Problem 16
            //// Question: What exception might occur if the input is invalid and how can you handle it
            //// If the input is invalid, such as a non numeric string like "abc", the int.Parse() method will throw a FormatException.If the input is null, it will throw an ArgumentNullException.And if the number is too large or too small to fit in an int, it will throw an OverflowException.These exceptions can be handled using a try-catch block to prevent the program from crashing and to provide a user friendly error message.
            //// Example
            //Console.WriteLine("enter your age : ");
            //string age = Console.ReadLine(); // prompts
            //int agevalue = int.Parse(age); // convert
            //// check if age is valid or invalid
            //if (agevalue > 0)
            //{
            //    Console.WriteLine("your age is valid");
            //}
            //else
            //{
            //    Console.WriteLine("your age is invalid");
            //}
            //// if the input is "abc" that is the exception
            //// How to handle it? Create if condition and if the user enter a string not number print an error message like "Please Enter an intege number or your correct age"
            #endregion

            #region Problem 17
            //// Problem: Write a program that demonstrates the difference between prefix and postfix increment operators using a variable x.
            //int x = 5;

            //// Postfix: x++ -> Use first, then increment
            //Console.WriteLine("Postfix x++: " + (x++)); // prints 5
            //Console.WriteLine("After postfix, x = " + x); // now x = 6

            //// Prefix: ++x -> Increment first, then use
            //Console.WriteLine("Prefix ++x: " + (++x)); // prints 7
            //Console.WriteLine("After prefix, x = " + x); // x still = 7
            #endregion

            #region Problem 18
            //// Question: Given the code below, what is the value of x after execution? Explain why
            //int x = 5;
            //int y = ++x + x++; // 12 -> 6 + 6
            //// value of x after execution is 13 cause the first declare of x is 5 and second line there are declare for the y value and in this line x is increamented by 1, then x now is 6 and after that x also increamented by 1 another time then 6 + 1 is now 7
            //// Then x value now is 7
            //Console.WriteLine(x); // 7
            #endregion 

            #endregion
        }
    }
}
