using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class StaticSample
    {
        public static void Main(string[] arg)
        {
            Sample s1 = new Sample(45);
            

            Sample s2 = new Sample(65);
            Sample s3 = new Sample(87);
            s1.Print();
            s2.Print();
            s3.Print();

            s1.Print();
            s2.Print();

            Sample.Disp();
            Console.WriteLine("count:  " + Sample.c);
            Console.ReadKey();
        }
    }

    class Sample
    {
         int a;
         internal static int c = 0;
        internal Sample()
        {
            a = 0;
            c++;
        }
        internal Sample(int a)
        {
            c++;
            this.a = a;
        }
       internal void Print()
        {
            Console.WriteLine(" a: " + a);
        }

      internal static void Disp()
       {
           Console.WriteLine(c);
       }
    }
}
