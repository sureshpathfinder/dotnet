using System;
using System.Collections.Generic;
using System.Text;

namespace ctrl_structure
{
    class Switch1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Switch");
            Console.WriteLine("Enter input");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                default:
                    Console.Write("invalid");
                    break;

            }
            Console.ReadKey();
        }

    }
}
