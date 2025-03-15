using System;
using System.Collections.Generic;
using System.Text;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the value");
            a = int.Parse(Console.ReadLine());
            Program p = new Program();
            Console.WriteLine("Factorial of "+a+"="+p.fact(a));
        }
        int fact(int n)
        {
            if (n == 1)
                return 1;
            else
                return (n * fact(n - 1));
        }



    }
}
