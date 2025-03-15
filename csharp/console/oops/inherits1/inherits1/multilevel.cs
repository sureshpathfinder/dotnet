using System;
using System.Collections.Generic;
using System.Text;

namespace inherits1
{
    class multilevel
    {
        static void Main(string[] args)
        {
            der2 d = new der2();
            d.disp();
            d.dispder1();
            d.dispder2();
            
        }

    }
    class baseclass
    {
        protected int a;
        public void disp()
        {
            Console.WriteLine("Base class");
        }
    }
    class der1:baseclass
    {
        public new void disp()
        {
           base.disp();
            Console.WriteLine("Derived1  class");
        }

        public void dispder1()
        {
            
            Console.WriteLine("Derived class 1");
        }
    }
    class der2:der1
    {
        public void dispder2()
        {
            a=10;
            Console.WriteLine("Derived class 2 a=" + a);
        }
    }

}
