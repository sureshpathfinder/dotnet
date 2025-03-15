using System;
using System.Collections.Generic;
using System.Text;
using maths;

namespace user_name
{
    class Program
    {
        static void Main(string[] args)
        {
            arith a = new arith();
            Console.WriteLine("2 square=" + a.square(2));
            Console.WriteLine("4 cube=" + a.cube(4));

        }
    }
}
