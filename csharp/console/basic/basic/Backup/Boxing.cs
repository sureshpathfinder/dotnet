using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Boxing
    {
        static void Main(string[] args)
        {
            int a = 7;
            Object n = a;// Boxing
            n = 52;
            Console.WriteLine("n=" + n + " a=" + a);
            int b = (int)n;// Unboxing
            Console.WriteLine("n=" + n + " b=" + b);
            Console.ReadKey();
        }
    }
}
