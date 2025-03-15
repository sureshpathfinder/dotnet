using System;
using System.Collections.Generic;
using System.Text;

namespace function
{
    class student
    {
        public static void Main(string[] ar)
        {
            student s = new student();
            s.disp();
            Console.WriteLine("add 12+43=" + s.add(12, 43));
            s.square(4);
            Console.WriteLine("fact of 5=" + s.fact(5));
            Console.WriteLine(s.print());
        }
       void disp()
        {
            Console.WriteLine("Method 1");
            disp1();
        }

        //no argument no return type
      void disp1()
        {
            Console.WriteLine("Method Disp 1 \"2 \" ");
        }
        //no argument with return type
      int print()
        {
            return 2;
        }
        //With argument with return type
       int add(int a, int b)
        {
            return a + b;
        }
        //With argument no return type
      void square(int a)
        {
           Console.WriteLine("Square of "+a+ " =" +( a * a));
        }

        //recursion
      int fact(int n)
        {
            if (n <=1)
                return 1;
            else
                return fact(n - 1) * n;
        }
    }
    
}
