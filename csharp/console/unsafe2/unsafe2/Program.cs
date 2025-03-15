using System;
using System.Collections.Generic;
using System.Text;

namespace unsafe2
{
    class Program
    {
        public static void Main()
        {
            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before Call a={0} b={1}", a, b);
            unsafe
            {
                swap(&a, &b);
            }
            Console.WriteLine("After Call a={0} b={1}", a, b);
        }
        unsafe public static void swap(int* a, int* b)
        {
            int temp = *a;
            *a = *b;
            *b = temp;
        }
    }
}
