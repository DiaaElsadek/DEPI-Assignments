using Problem_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    internal class Child : Parent
    {

        public int Z { get; set; }

        public Child(int X, int Y, int Z) : base(X, Y)
        {
            this.Z = Z;
        }

        public override string ToString()
        {
            return $"X : {X}, Y : {Y}, Z : {Z}";
        }

        /*
         
        In the Child class: 
            1. Override the Product() method using the new keyword. 
            2. Override it using the override keyword. 
         
        */

        // 1- Hide Product() using new
        //public new int Product()
        //{
        //    return X * Y * Z;
        //}

        // 2- Override Product() using override
        public override int Product()
        {
            return X * Y * Z;
        }

    }
}
