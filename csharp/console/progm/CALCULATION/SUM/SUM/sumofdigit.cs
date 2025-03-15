using System;
using System.Collections.Generic;
using System.Text;

namespace SUM
{
    class sumofdigit
    {
        public static void Main()
        {
            int n, r, s = 0;
            Console.WriteLine("enter the no");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                r = n % 10;
                s = s + r;
                n = n / 10;
            }
            Console.WriteLine("sum of digit=" + s);
            Console.ReadKey();
        }

    }
}
