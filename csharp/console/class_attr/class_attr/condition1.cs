#define A
#define B
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

        [Conditional("A")]
        public void sam()
        {
            Console.WriteLine("Sam Method");
        }

        [Conditional("B")]
        public void show()
        {
            Console.WriteLine("Show Method");
        }

        public static void Main(string[] ar)
        {
            Console.WriteLine("Main");
            condition1 c=new condition1();
            c.disp();
            c.sam();
            c.show();
            Console.WriteLine("Main");
        }

    }
}


