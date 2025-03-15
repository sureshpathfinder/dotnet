using System;
using System.Collections.Generic;
using System.Text;

namespace delegate2
{
    class Program
    {
        delegate int sam(int a);
        int square(int a)
        {
            return a*a;
        }
        int disp(int m)
        {
            return m;
        }
        static void Main()
        {
            Program p=new Program();
            sam s=new sam(p.square);
            Console.WriteLine("Square of 2  ="+s(2));
            sam s1=new sam(p.disp);
            Console.WriteLine("Print of 4="+s1(4));
            sam s2 = new sam(Math.Sqrt);
            Console.WriteLine("Sqrt of 4  =" + s2(4));


        }
    }
}
