using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class out_method
    {
        static void Main(string[] args)
        {
            out_method o = new out_method();
            int x;
            o.square(4, out x);
            Console.WriteLine("Square of 4=" + x);

        }
        public void square(int a, out int m)
        {

            m = a * a;

         }

    }
}
