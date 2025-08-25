using Problem_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Robot : IWalkable
    {

        public void Walk()
        {
            Console.WriteLine("Robot is walking using its normal legs");
        }

        // Explicit Interface Implementation
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking in IWalkable style (different behavior)");
        }

    }
}
