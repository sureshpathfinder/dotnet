using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class EVEN_ODD1
    {
        public static void Main(string[] ar)
        {
          int[] a = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] s = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var x =from n in a where (n%2==0) select s[n];

            Console.WriteLine("Event number :"); 
            foreach (var i in x)
            {
                Console.WriteLine(i);
            }

        }
    }
}
