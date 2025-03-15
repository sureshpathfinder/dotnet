using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] ar)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 12, 13, 45, 67 };

            var x = from n in a where n>12 select n;

            Console.WriteLine("Value > 12: ");
            foreach (var i in x)
                Console.WriteLine(i);
                
        }
    }
}
