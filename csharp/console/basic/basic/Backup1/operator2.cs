using System;
using System.Collections.Generic;
using System.Text;
namespace basic
{
    class operator2
    {
        public static void Main(string[] ar)
        {
            int a = 5, b = 3, c, d, ls, rs;

            //Conditional Operator
            Console.WriteLine("Greatest value: " + ((a > b) ? a : b));

            c = a & b;
            d = a | b;
            ls = a << 2;
            rs = b >> 2;

            Console.WriteLine("a=" + a + "   b=" + b);
            Console.WriteLine("c(And)=" + c + "   d(OR)=" + b);

            Console.WriteLine("Left Shift for 2=" + ls + "   Right Shift for 2=" + rs);
            Console.ReadKey();
        }
    }
}
