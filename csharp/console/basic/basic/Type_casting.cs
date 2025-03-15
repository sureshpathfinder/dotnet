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
            int a = 5, b =2;
              float c = a / b;
            Console.WriteLine("c=" + c);

            //Explicit type casting
            float x = 5.36F, y = 2.21F;
            int z =(int)(x / y);

            Console.WriteLine("Integer output=" + z);

            int m = 65;
            char ch = (char)(m);
            Console.WriteLine("char ch=" + ch);
            Console.ReadKey();
        }
    }
}

