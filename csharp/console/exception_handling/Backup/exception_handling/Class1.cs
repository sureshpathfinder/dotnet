using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class Class1
    {
        public static void Main()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("This line in not executed");
            
                int[] a = new int[10];
                a[23] = 2;
                Console.WriteLine("a[23]=" + a[23]);
            }

            catch (DivideByZeroException de)
            {
                Console.WriteLine(de);
                Console.WriteLine("Exception occured");
            }
            catch (IndexOutOfRangeException de)
            {
                Console.WriteLine(de);
                Console.WriteLine("Exception =");
            }
            Console.WriteLine("Result is {0}", div);
        }
    
    }
}
