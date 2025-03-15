using System;
using System.Collections.Generic;
using System.Text;

namespace call_value1
{
    class call_ref1
    {
        static void Main(string[] args)
        {
            int a = 3, b = 10;
            Console.WriteLine("before Swapping");
            Console.WriteLine("a=" + a + " b=" + b);
            call_ref1 p = new call_ref1();
            p.swap(ref a, ref b);
            Console.WriteLine("After Swapping");
            Console.WriteLine("a=" + a + " b=" + b);
        }
        void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
