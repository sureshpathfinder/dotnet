using System;
using System.Collections.Generic;
using System.Text;

namespace ctrl_structure
{
    class do_while1
    {
        static void Main(string[] ar)
        {
            Console.WriteLine("WHILE");
            Console.WriteLine("Enter the value=");

            int a = int.Parse(Console.ReadLine());
            do
            {
                Console.Write((a--) + " ");
            } while (a > 0);
            Console.ReadKey();
        }

    }
}
