using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class throw1
    {
        public static void Main()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;

                throw new DivideByZeroException("Invalid Division");

                Console.WriteLine("End");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception"+e);
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }
}
