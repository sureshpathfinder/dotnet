using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class param1
    {
        static void Main(string[] args)
        {
            param1  o = new param1 ();
            o.disp(2, 4, 5);
            o.disp(3, 5);
            o.disp(3);
        }
        void disp(params int[] a)
        {
            Console.WriteLine("params");
            foreach(int i in a)
            {
                Console.Write("  "+i);
            }
        }


    }
}
