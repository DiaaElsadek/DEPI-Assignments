using Problem_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    internal class File : IReadable, IWritable
    {

        /// <summary>
        /// Implementing Methods of IReadable and IWritable Interfaces Explicitly
        /// </summary>

        void IReadable.Read()
        {
            Console.WriteLine("I'm Read From IReadable Interface");
        }

        void IWritable.Read()
        {
            Console.WriteLine("I'm Read From IWritable Interface");
        }

        void IReadable.Write()
        {
            Console.WriteLine("I'm Write From IReadable Interface");
        }

        void IWritable.Write()
        {
            Console.WriteLine("I'm Write From IWritable Interface");
        }
    }
}
