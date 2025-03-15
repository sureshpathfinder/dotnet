using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int[] a = { 23, 45, 54, 23, 57, 65 };

            var x = a.Sum();
            var avg = a.Average();
            Console.WriteLine("a: " + a);
            Console.WriteLine("x: " + x);


        }
    }
}
