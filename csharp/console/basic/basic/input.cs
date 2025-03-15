using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class input
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter a String");
            s = Console.ReadLine();
            Console.WriteLine("string=" + s);

           
            int a;
            Console.WriteLine("Enter a integer value");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a char value");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter a float value");
            float f = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter a integer value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" \n a={0}", a);
            Console.WriteLine(" \t b={0}", b);
            //Console.WriteLine(" \" char=ytr\b"+c);
            Console.WriteLine(" \a  float="+f);

            Console.WriteLine("Sample program for \"variables\"");
            Console.WriteLine("location = c:\\programfile\\ds");
            Console.ReadKey();
        }



    }
}
