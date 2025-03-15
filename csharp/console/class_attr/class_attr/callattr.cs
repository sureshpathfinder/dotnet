#define B
using System;
using System.Collections.Generic;
using System.Text;

namespace class_attr
{
    class callattr
    {
        public static void Main(string[] a)
        {
            Console.WriteLine("Main");
            condition1 c = new condition1();
            c.disp();
            c.sam();
            c.show();
            Console.WriteLine("Main");
        }
    }
}
