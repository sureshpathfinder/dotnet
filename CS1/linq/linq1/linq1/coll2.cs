using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class coll2
    {
        public static void Main(string[] ar)
        {
            int[] a = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] s= { "zero", "one", "two", "three", 
                                   "four", "five", "six", "seven", "eight", "nine" };
            
            var x = from n in a where n > 5 select s[n];

            foreach (var i in x)
                Console.WriteLine(i);
 
        }
    }
}
