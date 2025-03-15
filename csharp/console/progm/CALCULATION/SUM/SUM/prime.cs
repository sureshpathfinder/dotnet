using System;
using System.Collections.Generic;
using System.Text;

namespace SUM
{
    class prime
    {
        public static void Main()
        {
            int n, i;
            Boolean b = true;
            Console.WriteLine("enter the no");
            n = int.Parse(Console.ReadLine());
            for (i = 2; i <= n / 2;i++ )
            {
                if (n % i == 0)
                    b = false;
                break;

            }
            if(b)
                Console.WriteLine(n+"is a Prime no");
            else
                Console.WriteLine(n+"is not  a Prime no");
        }

    }
}
