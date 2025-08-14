using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class TypeA
    {

        // 1- Create a class TypeA with attributes F (private), G (internal), and H (public). 
        private int F;   // Private: Accessible only inside this class
        internal int G;  // Internal: Accessible inside the same Project
        public int H;    // Public: Accessible from anywhere

        // 2- Write a program to access these attributes from different parts of the project.

        public void Print()
        {
            Console.WriteLine(F); // Can Access inside the class only
            Console.WriteLine(G); // Can Access inside the Project only
            Console.WriteLine(H); // Can Access anywhere
        }

    }
}
