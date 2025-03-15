using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class Sample
    {
        public static void Main(string[] a)
        {
            Console.WriteLine("Rect sample");
            Rect r = new Rect(23,4);
            r.Area();
            Console.ReadKey();
        }
    }

    class Rect
    {
        int l, b;
        internal Rect(int l , int b)
        {
            this.l = l;
            this.b = b;
        }

        internal void Area()
        {
            Console.WriteLine("area : " + (l * b));
        }
    }
}
