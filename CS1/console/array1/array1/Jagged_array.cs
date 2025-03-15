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
            a[0] = new int[2]{1,2};
            //a[0][0] = 1;
            //a[0][1] = 2;
                       
            a[1] = new int[5];
            a[1][0] = 1;
            a[1][1] = 2;
            a[1][2] = 3;
            a[1][3] = 4;
            a[1][4] = 5;

            for(int r=0;r<2;r++)
            {
                Console.Write("A[" +r +"]=    ");
                foreach (int i in a[r])
                {
                    Console.Write( i + "  " );
                }
                Console.WriteLine();
                
            }
            
        }

    }
}
