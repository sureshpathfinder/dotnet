using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    interface wire1
    {
        void disp();
       // void show();
    }

    class der1 : wire1
    {
        public void disp()
        {
            Console.WriteLine("Interface method");

        }
    }
    class der2 : wire1
    {
        public void disp()
        {
            Console.WriteLine("Der2 Interface Method");
        }
    }
    class program
    {
        public static void Main()
        {
            wire1 d1 = new der1();
            d1.disp();
            wire1 d2 = new der2();
            d2.disp();
        }
    }
}
