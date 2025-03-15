using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class operator1
    {
        static void Main(string[] args)
        {
            complex c1 = new complex(3, 4);
            complex c2 = new complex(2, 3);
            complex c3 = new complex();
            c3=c1 + c2;
            c1.disp();
            c2.disp();
            c3.disp();
            complex c4 = new complex();
            c4 = c1 - c2;
            c4.disp();

        }
    }
    class complex
    {
        int r, i;
        public complex()
        {
        }
        public complex(int a, int b)
        {
            r = a;
            i = b;
        }
        public static complex operator+(complex t,complex y)
        {
            complex s=new complex();
            s.r =y. r + t.r;
            s.i =y. i + t.i;
            return s;
        }
        public static complex operator -(complex y, complex t)
        {
            complex s = new complex();
            s.r = y.r - t.r;
            s.i = y.i - t.i;
            return s;
        }
        public void disp()
        {
            Console.WriteLine("Real no=" + r);
            Console.WriteLine("Imagnary=" + i);
        }
    }


}
