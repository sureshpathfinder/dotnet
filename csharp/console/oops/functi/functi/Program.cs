using System;
using System.Collections.Generic;
using System.Text;

namespace functi
{
    public class program
    {
        unsafe public static void swap1(int* a, int* b)
        {
            int temp = *a;
            *a = *b;
            *b = temp;
        }
        public static void Main()
        {
            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before Call a={0} b={1}", a, b);
            unsafe
            {
               
                program.swap1(&a, &b);
            }
            Console.WriteLine("After Call a={0} b={1}", a, b);
        }
    }

}
