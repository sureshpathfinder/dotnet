using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
	class Program
	{
		static void Main(string[] args)
		{
           int a, b, c;
            a = int.Parse(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            short s = 23;
            decimal d = 23.45m;
            float f = 23.3F;
          Boolean bo = true;
            char c1 = 'w';
            string s1 = "hello";
           
            Console.WriteLine("a=" + a);
            Console.WriteLine("a={0}b={1} c={2} ", a, b, c);

            Console.WriteLine("a=" + a + " b=" + b);

           Console.WriteLine("s={0} d={1} f={2}", s, d,f);
            Console.WriteLine(" \n a={0}", a);
            Console.WriteLine(" \t b={0}", b);

            Console.WriteLine("\aBoolean\b=" + bo);
            Console.WriteLine(" \"Char\'=" + c1);
            Console.WriteLine("D:\\SSI_SURESH\\program\\DOT NET");
            Console.WriteLine("String =" + s1);

            Console.ReadKey();

            
		}

	}
}
