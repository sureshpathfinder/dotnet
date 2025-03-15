using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Type_Casting
    {
        public static void Main()
        {
            //implicit type casting
            //int a = 5, b = 2;
            //float f =a / b;
            //Console.WriteLine("f=" + f);
            ////Explicit type casting
            //Console.WriteLine("Integer output=" + (int)(f));
            int a = 2;
            object o = a;
            int n = (int)a;
            Console.Write("c=" + sizeof(double));
            Console.Write("c=" + typeof(o));
            Console.Write("c=" + sizeof(double));





        }

    }
}

