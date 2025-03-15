using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class Constructor1
    {
        static void Main(string[] args)
        {
            sample s1 = new sample();
            sample s2 = new sample(2, 3);
            sample s3 = new sample(12, 13);
            sample s4 = new sample(s2);
            Console.ReadKey();
        }

        class sample
        {
            int x, y;
            //default constructor
            public sample()
            {
                Console.WriteLine("default constructor");
                
            }

            //parameterised constructor
            public sample(int a, int b)
            {
                x = a;
                y = b;
                Console.WriteLine("Parameterised constructor");
                Console.WriteLine("x=" + x + "  y=" + y);
            }

            //copy constructor
            public sample(sample m)
            {
                int a = m.x + m.y;
                Console.WriteLine("Copy Constructor=" + a);
            }
            //static Constructor
            static sample()
            {
                Console.WriteLine("welcome");
            }

            ~sample()
            {
                Console.WriteLine("deleted");
            }
        }
    }


}