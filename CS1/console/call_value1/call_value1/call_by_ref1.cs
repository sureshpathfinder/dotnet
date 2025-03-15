using System;
using System.Collections.Generic;
using System.Text;

namespace call_value1
{
    class call_by_ref1
    {
        static void Main(string[] args)
        {
            int a = 3, b = 10;
            Console.WriteLine("before Swapping");
            Console.WriteLine("a=" + a + "b=" + b);
            Program p = new Program();
            p.swap(ref a, ref b);
            Console.WriteLine("After Swapping");
            Console.WriteLine("a=" + a + "b=" + b);
        }
        void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
