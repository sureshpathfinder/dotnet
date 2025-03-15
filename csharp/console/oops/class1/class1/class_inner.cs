using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class class_inner
    {
        public static void Main(string[] ar)
        {
            outer o = new outer(5);
            
           outer.inner i = new outer.inner();
           i.disp();
        }
    }
    class outer
    {
       static int a;
       public outer(int x)
        {
            a = x;
        }
        public class inner
        {
              int b;

            public void disp()
            {
                b = 34;
                Console.WriteLine("a=" + a);
                Console.WriteLine("b=" + b);
            }
        }
    }

}
