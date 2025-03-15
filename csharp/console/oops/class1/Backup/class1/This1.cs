using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class This1
    {
        static void Main(string[] args)
        {
            sample2 s = new sample2(10, 20);
            
            s.print();

        }
    }
    class sample2
    {
        int a, b;

        public sample2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void print()
        {
            Console.WriteLine("a=" + a + "b=" + b);
        }
    }
}