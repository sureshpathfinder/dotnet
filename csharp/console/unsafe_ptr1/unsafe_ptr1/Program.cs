using System;
using System.Collections.Generic;
using System.Text;

namespace unsafe_ptr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10;
            Console.WriteLine("a="+a);
            unsafe
            {
            int* p = &a;

            Console.WriteLine("p="+(int)p);
            int** ptr = &p;
            Console.WriteLine("*p=" + (int)*p);
            Console.WriteLine("ptr=" + (int)ptr);
            Console.WriteLine("*ptr=" + (int)*ptr);
            Console.WriteLine("**ptr=" + (int)**ptr);

            }


        }
    }
}

        
