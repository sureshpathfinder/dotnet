using System;
using System.Collections.Generic;
using System.Text;

namespace array1
{
    class single1
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the 5 value");
            for (int i = 0; i < 5; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("The 5 value are");
            foreach (int i in a)
            {
                Console.Write(" " + i);
            }
            Array.Sort(a);
            Console.WriteLine("The  sorted 5 value are");
            Console.WriteLine("Length" + a.Length);
            foreach (int i in a)
            {
                Console.Write(" " + i);
            }
            Console.ReadKey();
            Console.Clear;
            int[] b={ 14, 25, 23, 54, 65 };
            Console.WriteLine("Length" + b.Length);
        }
    }
}
