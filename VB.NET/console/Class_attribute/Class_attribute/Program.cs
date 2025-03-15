//#define Selected
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Class_attribute
{
    class Program
    {
        [Conditional("Selected")]
        public void disp()
        {
            Console.WriteLine("Disp");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            Program p = new Program();
            p.disp();
            Console.WriteLine("Main");

        }
    }
}
