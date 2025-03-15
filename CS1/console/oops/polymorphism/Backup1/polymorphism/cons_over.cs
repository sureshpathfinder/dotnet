using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class cons_over
    {
        static void Main(string[] args)
        {
            sample s1 = new sample();
            sample s2 = new sample(2, 3);
            sample s3 = new sample(s2);
            sample s4 = new sample(2.4);
            sample s5 = new sample("welcome");
          

        }

    }
    class sample
    {
        int x, y;
        public sample()
        {
            Console.WriteLine("default constructor");
        }
        public sample(int a, int b)
        {
            x = a;
            y = b;
        }
        public sample(double a)
        {
            Console.WriteLine("Float Constructor=" + a);
        }

        public sample(string s)
        {
            Console.WriteLine("String Constructor=" + s);
        }

        public sample(sample s)
        {
            int m = s.x + s.y;
            Console.WriteLine("m=" + m);
        }
        static sample()
        {
            Console.WriteLine("welcome to static Constructor");
        }
        ~sample()
        {
            Console.WriteLine("deleted");
        }
      

    }


}
