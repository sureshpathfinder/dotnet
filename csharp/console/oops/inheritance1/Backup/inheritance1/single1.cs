using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance1
{
    class single1
    {
        public static void Main()
        {
            sub1 s = new sub1();
            s.geta();
            s.getb();
            s.disp();
        }

    }
    class supera
    {
        protected int a;
       public  void geta()
        {
            Console.WriteLine("Enter a value");
            a = int.Parse(Console.ReadLine());
        }
    }
    class superb:supera 
    {
        protected int b;
        public void getb()
        {
            Console.WriteLine("Enter b value");
            b = int.Parse(Console.ReadLine());
        }
    }
    class sub1 : superb
    {
        public void disp()
        {
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("addition=" +( a+b));
        }
    }


}
