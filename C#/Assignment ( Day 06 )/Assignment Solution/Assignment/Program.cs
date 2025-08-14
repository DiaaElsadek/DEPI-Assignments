using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Problem 1

            // Problem

            // 1- Create a struct Point with X and Y attributes
            // Go to struct point file

            // 2- Add constructors: default and parameterized
            // Go to struct point file

            // 3- Override the ToString() method to print the point as (X, Y)
            // Go to struct point file

            // Question

            // In C#, a struct cannot inherit from another struct or class 
            // because structs are value types and are designed to be lightweight. 
            // Allowing inheritance would increase their memory overhead and complexity, 
            // defeating their purpose of being simple, stack-allocated types.
            // However, structs can implement interfaces to achieve polymorphism without the cost of class inheritance.

            #endregion

            #region Problem 2

            //// Problem

            //// 1- Create a class TypeA with attributes F (private), G (internal), and H (public). 
            //// Go to TypeA Class file

            //// 2- Write a program to access these attributes from different parts of the project.

            //TypeA obj1 = new TypeA();

            //// obj1.F = 10; // Invalid Access Private Variable
            //obj1.G = 10; // Valid Access internal Variable
            //obj1.H = 10; // Valid Access public Variable

            //// Question

            //// Question: How do access modifiers impact the scope and visibility of a class member?
            //// Answer:
            //// Access modifiers in C# define the accessibility of class members (fields, methods, properties, etc.).
            //// - private: Accessible only within the same class.
            //// - internal: Accessible within the same assembly (project).
            //// - public: Accessible from any other class or assembly.
            //// They control encapsulation, security, and how different parts of a program interact with each other.

            #endregion

            #region Problem 3

            //// Problem

            //// 1- Define a struct Employee with private attributes (EmpId, Name, Salary). 

            //// 2- Use methods (GetName, SetName) and properties to access these attributes. 

            //// 3- Write a test program to demonstrate encapsulation in action. 

            //Employee employee1 = new Employee();

            //// Name
            //employee1.SetName("Diaa Elsadek"); // Set Name
            //Console.WriteLine(employee1.GetName()); // Diaa Elsadek

            //// Salary
            //employee1.EmployeeSalary = 10000; // Set Salary
            //Console.WriteLine(employee1.EmployeeSalary); // 10000

            //// Id
            //Console.WriteLine(employee1.GetId()); // default => 0

            //Console.WriteLine(employee1); // Assignment.Employee

            //// Question

            //// Question: Why is encapsulation critical in software design?
            //// Answer: Encapsulation is critical because it helps protect an object's internal state 
            //// from unintended interference or misuse. By restricting direct access to the fields 
            //// and exposing them through controlled methods (getters/setters) or properties, 
            //// we maintain data integrity, reduce coupling, and make the code more maintainable 
            //// and easier to debug.

            #endregion

            #region Problem 4

            //// Problem

            //// Define a struct Point with: 
            //// 1- A parameterized constructor initializing X to specific value and Y to 0.
            //// 2- A parameterized constructor to set X and Y to specific values.

            //// 3- Write a test program to demonstrate constructor overloading. 

            //Point1 P1;
            //P1 = new Point1(2);

            //Console.WriteLine(P1.ToString()); // X = 2, Y = 0

            //P1 = new Point1(5, 10);
            //Console.WriteLine(P1.ToString()); // X = 5, Y = 10

            //// Question

            //// In C#, constructors in structs are special methods used to initialize 
            //// the fields of the struct when a new instance is created. 
            //// Structs can have parameterized constructors but cannot have an explicit 
            //// parameterless (default) constructor — the compiler provides one automatically. 
            //// The constructor must assign values to all fields before it finishes execution.

            #endregion

            #region Problem 5

            //// Problem

            //// 1- Modify the ToString() method of the Point struct to include custom formatting.
            //// Go To Struct Point File

            //// 2- Write a program to test this by creating and printing multiple points. 

            //Point p1 = new Point(5, 10);
            //Point p2 = new Point(15, 20);
            //Point p3 = new Point(25, 30);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);

            //// Question

            //// Overriding the ToString() method provides a clear and readable 
            //// description of the object's data, improving code understanding and debugging.

            #endregion

            #region Problem 6

            // Problem

            // Go to the problem 6 project

            // Question



            #endregion

            #endregion

        }
    }
}
