using System;
using System.Collections.Generic;
using System.Text;

namespace inner_class1
{
    class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            s.show();
            sample.inn i = new sample.inn();
            i.disp();
            

        }
    }
    class sample
    {
        static int a;
        public class inn
        {
           public int x;
            public void disp()
            {
                a = 3;
                x = a;
                Console.WriteLine("Inner Method");
                Console.WriteLine("A=" + a);
            }
        }
        public void show()
        {
            inn i = new inn();
            i.x = 4;
            Console.WriteLine(i.x);
            Console.WriteLine("Outer Class");
        }
    }
}
