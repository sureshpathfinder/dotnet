using System;
using System.Collections.Generic;
using System.Text;

namespace array1
{
    class Jagged_array
    {
        static void Main(string[] args)
        {
            int[][] a = new int[2][];
            a[0] = new int[3];
            a[0][0] = 1;
            a[0][1] = 2;
            foreach (int i in a[0])
            {
                Console.WriteLine("a   " + i);
            }

            a[1] = new int[5];
            a[1][0] = 1;
            a[1][1] = 2;
            a[1][2] = 3;
            a[1][3] = 4;
            a[1][4] = 5;
            foreach (int i in a[1])
            {
                Console.WriteLine("a   " + i);
            }
            
        }

    }
}
