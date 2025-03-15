using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Class1
    {
        public static void Main(string[] ar)
        {
            int a,b;
            a = int.Parse(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a="+a+" end");
            Console.WriteLine("b value={0} a={1}",b,a);
        }
    }
}
