using Problem_5.Interfaces;
using System;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Robot R1 = new Robot();

            R1.Walk(); // Calls the normal method


            IWalkable R2 = new Robot();

            R2.Walk(); // Calls the explicit interface method

            #region Question

            // Question: How does explicit interface implementation help in resolving naming conflicts? 

            // Question: How does explicit interface implementation help in resolving naming conflicts?
            // Answer: Explicit interface implementation allows a class to provide separate 
            // implementations for methods with the same name from different interfaces, 
            // ensuring no conflict and clear separation of behaviors.

            #endregion

        }
    }
}
