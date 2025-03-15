using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class input
    {
        static void Main(string[] args)
        {
           
            int a;
            Console.WriteLine("Enter a value");
            a = int.Parse(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());        
            float f = float.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" \n a={0}", a);
            Console.WriteLine(" \t b={0}", b);
            Console.WriteLine(" \" char==\b"+c);
            Console.WriteLine(" \a float="+f);
        }



    }
}
