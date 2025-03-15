using System;
using System.Collections.Generic;
using System.Text;

namespace ctrl_structure
{
    class class_for
    {
        public static void Main(string[] ar)
        {
           
            Console.WriteLine("i  \t  j");
            for (int i =1,j=10; i <= 10; i++,j--)
            {
                Console.WriteLine(i + " \t "+ j);
                Console.ReadKey();
            }
        }
    }
}
