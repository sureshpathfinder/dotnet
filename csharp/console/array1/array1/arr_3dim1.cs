using System;
using x=System.Console;
using System.Collections.Generic;
using System.Text;

namespace array1
{
    class arr_3dim1
    {
        static void Main(string[] args)
        {
            int[,,] a = new int[2,2,3];

            int i, j,k;
            x.WriteLine("enter the 12 values");

            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("\n Layer " + i + " Values=");
                for (j = 0; j < 2; j++)
                {
                    for (k = 0; k < 3; k++)
                    {
                        String s = Console.ReadLine();
                        a[i, j,k ] = int.Parse(s);
                    }
                }
            }
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("\n Layer " + i + " Values=");
                for (j = 0; j < 2; j++)
                {
                    for (k = 0; k < 3; k++)
                    {
                        Console.Write(a[i, j,k] + "   ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
