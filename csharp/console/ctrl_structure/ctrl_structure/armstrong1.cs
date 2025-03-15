using System;
using System.Collections.Generic;
using System.Text;

namespace ctrl_structure
{
    class armstrong1
    {
        public static void Main(string[] ar)
        {
            Console.WriteLine("Amstrong the number");
            int n, r, s = 0, a;
            Console.WriteLine("Enter the number=");
            n=int.Parse(Console.ReadLine());
            a = n;
            while (n > 0)
                {
                    r = n % 10;
                    s = s + r * r * r;
                    n = n / 10;
                }
                //Console.WriteLine("s=" + s);
                if (a == s)
                    Console.WriteLine(a + " is a Armstrong number");
                else
                    Console.WriteLine(a + " is not a Armstrong number");
            }
            
        }
    
}
