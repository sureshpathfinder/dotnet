using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rand1
{
    class Program
    {
        static void Main(string[] args)
        {
            disp();
            disp();

        }
        static Random r = new Random();
        static void disp()
        {
            Console.WriteLine(r.Next(10));
        }
             
    }
}
