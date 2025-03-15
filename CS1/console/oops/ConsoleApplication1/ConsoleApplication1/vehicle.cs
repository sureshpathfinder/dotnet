using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class vehicle
    {
        protected int vid;
        internal double price;
        internal string color;
        internal vehicle(int id, double price, string color)
        {
            vid = id;
            this.price = price;
            this.color = color;
        }

        internal void Print()
        {
            Console.WriteLine("id  :"+ vid);
            Console.WriteLine("prie  :"+ price);
            Console.WriteLine("color  :"+ color);
        }

    }
}
