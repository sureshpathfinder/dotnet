using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class MyClass
    {
        public void Method()
        {
            try
            {
                int x = 0;
                int sum = 100 / x;
                throw new DivideByZeroException("welcome");
                Console.WriteLine("Sum=" + sum);
            }
            catch (DivideByZeroException e)
            {
                throw;
               //Console.WriteLine("Exception caught here");
            }
        }
    }
    class rethrow1
    {
        public static void Main()
        {
            MyClass mc = new MyClass();
            try
            {
                mc.Method();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here"+e);
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }
}
