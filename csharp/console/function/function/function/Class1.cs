using System;
using System.Collections.Generic;
using System.Text;

namespace function
{
    class Class1
    {
       public void display()
        {
            Console.WriteLine("Welcome to function");
        }

      public   int add(int a, int b)
        {
            return a + b;
        }
        public int fact(int f)
        {
            if (f == 1)
                return f;
            else
                return f * fact(f - 1);
        }
        public void show()
        {
            display();
        }


        public string taxcalc(double salary, out double tax,out double pf)
        {
            tax = salary * 0.05;
            pf = salary * 0.02;
            return "Tax calculation: ";
        }


        public void sum(params int[] a)
        {
            int s = 0;
            foreach (int x in a)
                s = s + x;
            Console.WriteLine("Sum: " + s);
        }
        public static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.show();
            Console.WriteLine("Addition: " + c.add(3,4));
            Console.WriteLine("Factorial: of 4 : " + c.fact(4));

            double t,pf;

            Console.WriteLine(c.taxcalc(23000, out t,out pf));
            Console.WriteLine(t);
            Console.WriteLine("Pf: " + pf);

            c.sum(3,5,6);
            c.sum(3, 5,6,4,6,3);

        }
    }
}
