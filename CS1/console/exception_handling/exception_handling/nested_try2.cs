using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class nested_try2
    {
        public static void Main()
        {
            int x = 3, y =0, div;
            try
            {
                div = x / y;
                Console.WriteLine("div =" + div);
                try
                {

                    int[] a = { 23, 4, 2, 5 };
                    Console.WriteLine("a[7]=" + a[7]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception ");
                }


            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured DivideByZeroException");
            }

        }
    }
}
