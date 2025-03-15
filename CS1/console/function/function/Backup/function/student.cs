using System;
using System.Collections.Generic;
using System.Text;

namespace function
{
    class student
    {
        internal void disp()
        {
            Console.WriteLine("Method 1");
            disp1();

        }
        private void disp1()
        {
            Console.WriteLine("Method Disp 1 \"2 \" ");

        }
        public int print()
        {
            return 2;
        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public int square(int a)
        {
            return a * a;
        }
        public int fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return fact(n - 1) * n;
        }




    }
    
}
