using System;
using System.Collections.Generic;
using System.Text;

namespace function
{
    class Class3
    {
        public static void Main(string[] arg)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Before swapping");
            //Console.WriteLine(" a: " + a + " b : " + b);

            Class3 c = new Class3();
            c.swap(ref a, ref b);
            //Console.WriteLine("After swapping");
            //Console.WriteLine(" a: " + a + " b : " + b);                
        }
        public void swap(ref int a, ref int b)
        {
            a = ((a + b) - (b = a));
            Console.WriteLine(" a: " + a + " b : " + b);    
        }

    }
}
