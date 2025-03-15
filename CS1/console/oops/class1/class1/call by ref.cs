using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class call_by_ref
    {
        public static void Main(string[] ar)
        {
            call_by_ref c = new call_by_ref();
            int a = 2, b = 3;

            Console.WriteLine("Before Swapping");
            Console.WriteLine("A=" + a + "  b= " + b);

            c.swap(ref a,ref b);
            Console.WriteLine("After  Swapping");
            Console.WriteLine("A=" + a + "  b= " + b);
        }
        public void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
