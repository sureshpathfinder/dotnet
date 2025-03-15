using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class static1
    {
        public static void Main()
        {
            sam1 s = new sam1(4,5);
            s.disp();
            sam1 s1 = new sam1();
            s1.disp();
        }
        

    }
    class sam1
    {
        static int a;
        int m;

        public sam1()
        {
        }
        public sam1(int x,int n)
        {
            a = x;
            m = n;

        }
        public void disp()
        {
            Console.WriteLine("a=" +a);
            Console.WriteLine("m=" + m);
        }
    }


}
