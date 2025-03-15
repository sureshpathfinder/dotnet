using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class Class1
    {
        public static void Main()
        {
            int x = 3, y = 0, div;
            try
            {
                div = x / y;
                Console.WriteLine("div =" + div);

                int[] a = { 23, 4, 2, 5 };
                Console.WriteLine("a[7]=" + a[7]);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Exception = IndexOutOfRangeException");
            }
            
        }
    
    }
}
