using System;
using System.Collections.Generic;
using System.Text;

namespace array1
{
    class arr_2dim
    {

        static void Main(string[] args)
        {
            int[,] a = new int[2, 3];

            int i, j;
            Console.WriteLine("enter the 6 values");

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    String s = Console.ReadLine();
                    a[i, j] = int.Parse(s);
                }
            }
            Console.WriteLine("\n A matrix=");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + "   ");

                }
                Console.WriteLine();
            }
        }
    }
}
