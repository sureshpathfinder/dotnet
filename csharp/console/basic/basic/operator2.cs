using System;
using System.Collections.Generic;
using System.Text;
namespace basic
{
    class operator2
    {
        public static void Main(string[] ar)
        {
            int a = 3, b = 5, c, d, ls, rs, n;

            //Conditional Operator
            Console.WriteLine("Greatest value: " + ((a > b) ? a : b));

            #region operator
            n = ~a;
            Console.WriteLine("a=" + a);

            Console.WriteLine("Ones complement: " + n);

            c = a & b;
            d = a | b;
            ls = a << 2;
            rs = b >> 2;

            #endregion
            Console.WriteLine("a=" + a + "   b=" + b);
            
            Console.WriteLine("c(And)=" + c + "   d(OR)=" + d);

            Console.WriteLine("Left Shift for 2=" + ls + "   Right Shift for 2=" + rs);
            Console.ReadKey();
        }
    }
}
