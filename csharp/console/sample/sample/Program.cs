using System;
using System.Collections.Generic;
using System.Text;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,r,s=0,n;
            Console.WriteLine("Enter the number:");
            a = int.Parse(Console.ReadLine());
            n = a;

            while (a > 0)
            {
                r = a % 10;
                s = s * 10 + r;
                a = a / 10;
            }
            Console.WriteLine("Reverse a number" + s);
            if (n == s) Console.WriteLine("The Given Number Is Perfect Number");
            else Console.WriteLine("The Given Number Is Not Perfect Number");






        }
    }
}
