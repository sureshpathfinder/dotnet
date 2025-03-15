using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class SamplePro
    {
        public static void Main(string[] arg)
        {
            Rect r = new Rect(2, 3);

            Rect s = new Rect(2, 2);

            Rect r2 = new Rect(r);
            r.Print();
           
         
            r2.Print();
            Console.ReadKey();
        }

        static SamplePro()
        {
            Console.WriteLine("Hi! Hello welcome to my class");
        }
    }

    class Rect : IDisposable
    {
        int h, w;

        //Default contructor
        internal Rect()
        {
            h = 4;
            w = 4;
        }

        //Parameterized contructor
        internal Rect(int x)
        {
            w = x;
            h = x;
        }

        //Parameterized contructor - contructor chaining
        internal Rect(int a, int b): this(b)
        {
            h = a;          
        }

        //Copy contructor
        internal Rect (Rect a)
        {
            this.h = a.h * 2;
           this.w = a.w * 2;
        }

        internal void Print()
        {
            Console.WriteLine(" Height : " + h);
            Console.WriteLine(" Width : " + w);
        }

        ~Rect()
        {
            Console.WriteLine("Deleted");
        }

        public void Dispose()
        {
           
        }
    }
}
