using System;
using System.Collections.Generic;
using System.Text;

namespace problem
{
    class perfect1
    {
        static void Main(string[] args)
        {
            int a, r, s = 0;
            Console.WriteLine("Enter the value");
            a = int.Parse(Console.ReadLine());
            int t = a;
            while (a > 0)
            {
                r = a % 10;
                s = s *10+ r;
                a = a / 10;
            }
           // Console.WriteLine("Sum of digit" + s);
             Console.WriteLine("Reverse number" + s);
            if(s==t)
                Console.WriteLine("The number is perfect" + s);
            else
                Console.WriteLine("The number is not a perfect" + s);



        }


    }
}
