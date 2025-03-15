using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class Program
    {
        public static void Main()
        {
            int x=3, y= 10,div;
            try
            {
                div = x / y;
                Console.WriteLine("div =" + div);
                
                int[] a = { 23, 4, 2, 5 };
                Console.WriteLine("a[7]=" + a[7]);

                ArrayList al = null;
                al.Add(23);

                Console.WriteLine(al[0]);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero error   ");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array index not found   ");
            }
                Console.ReadKey();
        }
    }
}
