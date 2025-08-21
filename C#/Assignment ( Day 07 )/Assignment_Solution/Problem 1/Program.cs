using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem

            // 1- Define a class Car with properties Id, Brand, and Price. 
            // Created

            // 2- Write multiple constructors
            // Go to the Car.cs file ( Car Class )

            // 3- Demonstrate the constructors by creating objects.

            Car car1 = new Car(1, "BMW", 50000);

            Console.WriteLine(car1.ToString());

            Car car2 = new Car(2);

            Console.WriteLine(car2.ToString());

            Car car3 = new Car(3, "Mercedic");

            Console.WriteLine(car3.ToString());

            Car car4 = new Car();

            Console.WriteLine(car4.ToString());

            #endregion

            #region Question

            // Question: Why does defining a custom constructor suppress the default constructor in C#?

            // In C#, if you define any custom constructor (with parameters),
            // the compiler does NOT automatically generate the parameterless
            // default constructor. You must explicitly define it if needed.

            #endregion

        }
    }
}
