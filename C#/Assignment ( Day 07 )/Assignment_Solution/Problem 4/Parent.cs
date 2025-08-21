using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    internal class Parent
    {

        public int X { get; set; }

        public int Y { get; set; }

        public Parent(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return $"X : {X}, Y : {Y}";
        }

        // 1- Define a method Product() in the Parent class to return X * Y.
        //public int Product()
        //{
        //    return X * Y;
        //}

        // For The Child Class

        public virtual int Product()
        {
            return X * Y;
        }

    }
}
