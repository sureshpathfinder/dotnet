using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            a.disp();
            a.disp(2, 4);
            int i = a.disp(2);
            Console.WriteLine("Integer i=" + i);
            long l = a.disp(23232);
            Console.WriteLine("Long i=" + l);

        }

        void disp()
        {
            Console.WriteLine("Simple Function");
        }
        void disp(int a, int b)
        {
            Console.WriteLine("Single Argument Function a=" + a + "b=" + b);
        }
        int disp(int n)
        {
            return n;
        }
        long disp(long l)
        {
            return l;
        }
    }
}
