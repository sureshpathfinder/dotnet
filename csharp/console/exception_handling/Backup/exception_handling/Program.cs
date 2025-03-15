using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class Program
    {
        public static void Main()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("This line in not executed");
            
              
            }

            catch (DivideByZeroException de)
            {
                Console.WriteLine(de);
                Console.WriteLine("Exception occured");
            }
            Console.WriteLine("Result is {0}", div);
        }
    }
}
