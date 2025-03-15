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
        int real, imaginary;
        public complex()
        {
        }
        public complex(int a, int b)
        {
            real = a;
            imaginary = b;
        }
        public static complex operator+(complex m,complex n)
        {
            complex s=new complex();
            s.real =m. real + n.real;
            s.imaginary =m. imaginary + n.imaginary;
            return s;
        }
        public static complex operator -(complex m, complex n)
        {
            complex s = new complex();
            s.real = m.real - n.real;
            s.imaginary = m.imaginary - n.imaginary;
            return s;
        }
        public void disp()
        {
            Console.WriteLine("Real no=" + real);
            Console.WriteLine("Imagnary=" + imaginary);
        }
    }


}
