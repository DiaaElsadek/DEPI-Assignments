using Assignment_Day08.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day08
{
    internal class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Start Car");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stop Car");
        }

    }
}
