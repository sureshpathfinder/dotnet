using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class static_m
    {
        static void Main(string[] args)
        {
            method1 m = new method1(20,3);
            method1.disp(m);
            method1.disp(m);
            method1.disp(m);
            //method1.ptt();
           // method1 m1 = new method1(10);

        }
       
    }
    class method1
    {
      static int a;
        int b;
        public method1(int i,int j)
        {
            a = i;
            b = j;
        }
        public static void disp(method1 m)
        {
            a++;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" +m.b);
        }
        public void ptt()
        {
            Console.WriteLine("ptt");
        }

    }

}
