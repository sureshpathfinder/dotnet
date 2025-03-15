using System;
using System.Collections.Generic;
using System.Text;

namespace SUM
{
    class FACT
    {
        static void Main(string[] args)
        {
            int a,fact=1;
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
                fact =fact* i;
            Console.WriteLine("Factorial of " + a + "=" + fact);
            Console.ReadKey();


        }
    }
}
