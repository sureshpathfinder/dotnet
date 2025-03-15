using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class rethrow1
    {
        public static void Main()
        {
            int x, y, div;
            try
            {
                Console.WriteLine("Enter the denominator and numerator:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                if (y == 0)
                    throw new DivideByZeroException("Invalid Division");
                else
                {
                    div = x / y;
                    Console.WriteLine("div =" + div);
                }
            }
            catch (DivideByZeroException e)
            {
                throw;
               // Console.WriteLine("Exception" + e);
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }
}
