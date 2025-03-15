using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class throw1
    {
        public static void Main()
        {
            int x , y , div;
            try
            {
                Console.WriteLine("Enter the denominator and numerator:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                if (y == 0)
                    throw new DivideByZeroException("Invalid Division");
                else
                {
                    Console.WriteLine("x: " + x);
                    Console.WriteLine("y: " + y);
                    Console.WriteLine(" Calculation");
                    div = x / y;
                    Console.WriteLine("div =" + div);
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception :"+e.Message);
            }
            Console.WriteLine("LAST STATEMENT");
            Console.ReadKey();
        }
    }
}
