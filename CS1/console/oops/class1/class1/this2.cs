using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class this2
    {
        public static void Main(string[] ar)
        {
            sam s = new sam(21, 3);
            s.disp();
        }
    }

    class sam
    {
        int a, b;
        public sam(int a)
        {
            Console.WriteLine("Single parameter");
            this.a = a;
        }
        public sam(int i,int b):this(i)
        {
            Console.WriteLine("Two parameter");
           this.b=b;
        }
        public void disp()
        {
            Console.WriteLine("a="+a+"  b="+b);
        }
    }
}
