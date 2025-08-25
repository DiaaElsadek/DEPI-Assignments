using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part_02.Interfaces;

namespace Part_02
{
    class SquareSeries : IShapeSeries
    {

        private int side = 0;
        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            side++;
            CurrentShapeArea = side * side;
        }

        public void ResetSeries()
        {
            side = 0;
            CurrentShapeArea = 0;
        }

    }
}
