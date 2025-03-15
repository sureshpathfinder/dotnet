//#define A
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace class_attr
{  
  
    class condition1
    {
        [Conditional("A")]
        public void disp()
        {
            Console.WriteLine("Disp");
        }
        public static void Main()
        {
            Console.WriteLine("Main");
            condition1 c=new condition1();
            c.disp();
            Console.WriteLine("Main");
        }

    }
}


