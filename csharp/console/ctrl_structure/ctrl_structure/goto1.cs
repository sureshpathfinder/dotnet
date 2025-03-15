using System;
using System.Collections.Generic;
using System.Text;

namespace ctrl_structure
{
    class goto1
    {
        static void Main(string[] ar)
        {
            int n;
        m:
            Console.WriteLine("Enter the number:");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
                goto m;
            else if(n==0)
                Console.WriteLine("n is zero");
            else if (n%2== 0)
                Console.WriteLine("n is Even");
            else
                Console.WriteLine("n is Odd");

        }
              
    }
}
