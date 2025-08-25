using Assignment_Day08.Interfaces;
using System;

namespace Assignment_Day08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IVehicle myCar = new Car();
            myCar.StartEngine();
            myCar.StopEngine();

            Console.WriteLine("");

            IVehicle myBike = new Bike();
            myBike.StartEngine();
            myBike.StopEngine();

            #region Question

            // Question: Why is it better to code against an interface rather than a concrete class?  

            // It is better to code against an interface rather than a concrete class because:
            // 1. It promotes loose coupling: code depends on abstractions, not specific implementations.
            // 2. It increases flexibility: implementations can be swapped without changing the calling code.
            // 3. It improves testability: mock or fake implementations can be injected for unit testing.
            // 4. It supports scalability and maintainability: systems can evolve more easily over time.

            #endregion

        }
    }
}
