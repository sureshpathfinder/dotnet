using System;
using System.Collections.Generic;
using System.Text;

namespace ctrl_structure
{
    class vowels1
    {
        public static void Main(string[] ar)
        {
            Console.WriteLine("Enter the char=");
            char c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine(c + "  is a Vowel");
                    break;
                default:
                    Console.WriteLine(c + " is a Consonant");
                    break;
            }
            Console.WriteLine("End OF Program");
            Console.ReadKey();
        }
    }
}
