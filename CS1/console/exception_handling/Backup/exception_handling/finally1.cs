using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class finally1
    {
        public static void Main()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
                throw new DivideByZeroException();
                
                int[] a = new int[2];
                a[4] = 34;
                Console.WriteLine(a[4]);
            }
            catch(DivideByZeroException de)
            {
                Console.WriteLine("Exception occured");
                throw;
            }
            catch (IndexOutOfRangeException de)
            {
                Console.WriteLine("Array Index Out of range Exception occured"+de);
            }
            
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine("Result is {0}", div);
        }
    }
}
