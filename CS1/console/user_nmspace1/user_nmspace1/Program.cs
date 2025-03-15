using System;
using System.Collections.Generic;
using System.Text;
using name_space1;
using name_space1.name_space2;

namespace user_nmspace1
{
    class Program
    {
        static void Main(string[] args)
        {
            arith1 a = new arith1();
            Console.WriteLine("Mul of 2*4=" + a.mul(2, 4));
            fun f = new fun();
            Console.WriteLine("Square of 3=" + f.square1(3));


        }
    }
}
