using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class even2
    {
        public static void Main(string[] ar)
        {
            int[] a = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
       
            var x =from n in a select new
                    { 
                        Digit = n, Even = (n % 2 == 0) 
                        };
                     
            foreach (var i in x)
            {
                Console.WriteLine("The digit ="+i.Digit+ " Even or Odd= "+(i.Even ? "even" : "odd"));
            }

        }
    }
}
