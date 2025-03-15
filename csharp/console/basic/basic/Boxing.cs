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
            object o = a;// Boxing
           
            Console.WriteLine("Object=" + o + " a=" + a);

            int b = (int)o;// Unboxing
            Console.WriteLine("Object=" + o + " b=" + b);

            Object x = "43tfdt";
            Console.WriteLine("x=" + x);
            
            Console.ReadKey();
        }
    }
}
