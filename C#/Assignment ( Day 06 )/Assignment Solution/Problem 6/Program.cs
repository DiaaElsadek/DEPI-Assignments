using System;

namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem 6

            // Problem

            // 1- Create a struct Point and a class Employee. 
            // Done

            // 2- Write a program to demonstrate value type (struct) and reference type (class) behavior when passing them to methods.

            // Struct is a Value Type => Point

            Point P1 = new Point(10, 20);
            Point P2 = new Point(50, 100);

            Console.WriteLine(P1.ToString()); // X = 10, Y = 20
            Console.WriteLine(P2.ToString()); // X = 50, Y = 100

            P1 = P2;

            P1.X = 5;
            P1.Y = 25;

            Console.WriteLine(P1.ToString()); // X = 5, Y = 25
            Console.WriteLine(P2.ToString()); // X = 50, Y = 100

            // Class is a Reference Type => Employee

            Employee Emp1 = new Employee(20000, "Diaa");
            Employee Emp2 = new Employee(1000, "Ahmed");

            Console.WriteLine(Emp1.GetName()); // Diaa
            Console.WriteLine(Emp2.GetName()); // Ahmed

            Console.WriteLine(Emp1.EmployeeSalary); // 20000
            Console.WriteLine(Emp2.EmployeeSalary); // 1000

            Emp2 = Emp1;

            Emp2.SetName("Mohamed");
            Emp2.EmployeeSalary = 50000;

            Console.WriteLine(Emp1.GetName()); // Moahmed
            Console.WriteLine(Emp2.GetName()); // Mohamed

            Console.WriteLine(Emp1.EmployeeSalary); // 50000
            Console.WriteLine(Emp2.EmployeeSalary); // 50000

            // Question

            // In C#, structs are value types and are usually allocated on the stack (or inline within another type),
            // meaning each variable holds its own copy of the data. 
            // Classes are reference types and are always allocated on the heap,
            // meaning variables hold a reference (pointer) to the same memory location.
            // Therefore, assigning a struct copies the data, while assigning a class copies the reference.


            #endregion

        }
    }
}
