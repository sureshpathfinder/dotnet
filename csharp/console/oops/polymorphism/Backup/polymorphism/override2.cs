using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class base1
    {
        public int a;
        public void disp()
        {
            a = 10;
        }
    }
    class der1:base1
    {
      
        public new void disp()
        {
            base.disp();
           Console.WriteLine("A="+ a);
        }
    }
    class override2
    {
        public static void Main()
        {
            der1 d = new der1();
            d.disp();
        }
    }

}
