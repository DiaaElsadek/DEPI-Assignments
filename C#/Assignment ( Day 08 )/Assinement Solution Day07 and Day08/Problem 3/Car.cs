using Problem_3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    internal class Car : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Car Class Implemented IMovable Interface");
        }
    }
}
