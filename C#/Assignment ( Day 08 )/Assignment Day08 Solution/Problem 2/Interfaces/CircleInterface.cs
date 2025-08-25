using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Interfaces
{
    internal class CircleInterface : IShape
    {

        public double Radius { get; set; }

        public CircleInterface(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public void Display()
        {
            Console.WriteLine("This is a circle (interface-based)");
        }

        #region Question

        // Question: When should you prefer an abstract class over an interface?  

        // You should prefer an abstract class over an interface when:
        // 1. You need to provide common/shared implementation to all derived classes.
        // 2. You want to define fields or constructors (not possible in interfaces).
        // 3. You expect the hierarchy to be closely related (strong "is-a" relationship).
        // 4. You want to evolve the base class with both abstract and non-abstract members.
        // 5. You need better versioning support in older C# versions (before default interface methods in C# 8.0).

        #endregion

    }
}
