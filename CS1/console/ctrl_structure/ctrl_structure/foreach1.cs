using System;
using System.Collections.Generic;
using System.Text;

namespace ctrl_structure
{
    class foreach1
    {
        static void Main(string[] ar)
        { 
            int[] a={1,2,3,4,45,56};


            for (int i = 0; i < 6; i++)
            {
                Console.Write(a[i] + " ");

            }

            Console.WriteLine(" \n Using for each");
            foreach(int i in a)
            {
                Console.Write( i+"  ");
            }
        }

    }
}
