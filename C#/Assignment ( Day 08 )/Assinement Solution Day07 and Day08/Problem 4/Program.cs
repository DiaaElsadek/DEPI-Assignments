using Problem_4.Interfaces;
using System;

namespace Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // IWritable

            IWritable writable = new File();

            writable.Write();
            writable.Read();

            // IReadable

            IReadable readable = new File();

            readable.Write();
            readable.Read();

            #region Question

            // Question: How does C# overcome the limitation of single inheritance with interfaces? 

            // C# overcomes the limitation of single inheritance by allowing a class 
            // to implement multiple interfaces. 
            // While a class can only inherit from one base class, 
            // it can implement any number of interfaces, 
            // enabling multiple behaviors and contracts to be combined.

            #endregion

        }
    }
}
