using System;
using System.Collections.Generic;
using System.Text;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a ={ 2, 2, 3, 44,15 };


            for (int i = 0; i < 5; i++)

                Console.WriteLine("  " + a[0] + "  " + a[1] + "  " + a[2] + "  " + a[3] + "  " + a[4]);
            Array.Sort(a);

            Console.WriteLine("Ascending Order");
            foreach (int i in a)
                Console.WriteLine("  " + i);


            Array.Reverse(a);
            Console.WriteLine("Desending Order");
            for (int i = 0; i < 5; i++)
                Console.WriteLine("a[" + i + "]=" + a[i]);
            Console.ReadKey();

            
        }

    }
}

