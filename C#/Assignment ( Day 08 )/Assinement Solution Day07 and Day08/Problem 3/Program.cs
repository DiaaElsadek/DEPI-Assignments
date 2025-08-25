using Problem_3.Interfaces;
using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IMoveable moveable = new Car();

            moveable.Move();

            #region Question

            // Question: Why is it useful to use an interface reference to access implementing class methods?

            // Using an interface reference to access implementing class methods is useful because:
            // 1. It enables polymorphism: you can treat different classes uniformly through a common interface.
            // 2. It allows flexibility: you can switch implementations without changing the calling code.
            // 3. It improves testability: you can inject mock or fake implementations for testing.
            // 4. It promotes loose coupling: code depends on abstractions (interfaces) rather than concrete classes.

            #endregion

        }
    }
}
