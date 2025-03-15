using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            x:
            try
            {
                Console.WriteLine("Enter 2 values: ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                //if (b <= 0)
                //    throw new DivideByZeroException("Error occurs");
                Console.WriteLine("A: " + a);
                Console.WriteLine("B: " + b);

                c = a / b;
                Console.WriteLine("C: " + c);
            }
                //multiple catch block
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Dividend should not be zero ");
                b = 1;
                //throw e;   //rethrow block
                goto x;
            }
            catch (FormatException f)
            {
                Console.WriteLine("Enter the valid input: ");
                goto x;
            }
        }
    }
}
