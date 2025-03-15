using System;
using System.Collections.Generic;
using System.Text;

namespace SUM
{
    class fibo
    {
        public static void Main()
        {

            int a = -1, b = 1, c, n;
            Console.WriteLine("Enter the no");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                Console.WriteLine("  " + c);
                a = b;
                b = c;
            }
        }



        
    }
}
