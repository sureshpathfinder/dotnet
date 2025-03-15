using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class prime1
    {
        public static void Main(string[] ar)
        {
            
            int[] a = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] s = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var x = from n in a
                    select new
                    {
                        Digit = s[n],
                        P = prime1.prime(n),
                        M="fdsf"
                    };

            foreach (var i in x)
            {
                Console.WriteLine("The digit =" + i.Digit + "    \t Prime or not= " + (i.P ? "Prime" : "Not a Prime"));
            }

        }
        public static bool prime(int n)
        {
            int c=0;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    c = 1;
                    break;
                }
            }
            if (c==0)
                return true;
            else
                return false;
        }
            


    }
}
