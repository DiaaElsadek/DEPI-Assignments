using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle rectangle = new Rectangle();

            rectangle.Draw();

            #region Question

            // Question: Why can't you create an instance of an interface directly?

            // You cannot create an instance of an interface directly 
            // because an interface does not provide implementation. 
            // It only defines a contract (methods, properties, events) 
            // that must be implemented by a class or struct.

            #endregion

        }
    }
}
