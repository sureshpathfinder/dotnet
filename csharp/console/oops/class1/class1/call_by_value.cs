using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class call_by_value
    {
        public static void Main(string[] ar)
        {
            call_by_value c = new call_by_value();
            int a=2, b=3;

            Console.WriteLine("Before Swapping");
            Console.WriteLine("A=" + a + "  b= " + b);

            c.swap(a, b);
            Console.WriteLine("After  Swapping");
            Console.WriteLine("A=" + a + "  b= " + b);
        }
        public void swap(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
