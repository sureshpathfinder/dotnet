using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 2 values: ");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C: " + c);
            }
            catch (Exception e)
            {
                Console.WriteLine("It as a Error: " );
            }
            finally
            {
                Console.WriteLine("Thank U");
            }
        }
    }
}
