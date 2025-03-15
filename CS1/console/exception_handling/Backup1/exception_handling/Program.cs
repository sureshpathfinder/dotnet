using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class Program
    {
        public static void Main()
        {
            int x=3,y=10,div;
            try
            {
                div = x / y;
                Console.WriteLine("div =" + div);

                int[] a = { 23, 4, 2, 5 };
                Console.WriteLine("a[7]=" + a[7]);
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception occured  :  " + e);
            }
            
        }
    }
}
