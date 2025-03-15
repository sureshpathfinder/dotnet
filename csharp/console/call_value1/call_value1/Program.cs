using System;
using System.Collections.Generic;
using System.Text;

namespace call_value1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 10;
            Console.WriteLine("before Swapping");
            Console.WriteLine("a=" + a + " b=" + b);
            Program p = new Program();
            p.swap(a,b);
            Console.WriteLine("After Swapping");
            Console.WriteLine("a=" + a + " b=" + b);
            Console.ReadKey();
        }
        void swap(int a,int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
