using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class base1
    {
        public int a;
        public void get()
        {
            Console.WriteLine("Enter the value: ");
            a = int.Parse(Console.ReadLine());

        }
        public void calc()
        {
            Console.WriteLine("Base method: ");
            Console.WriteLine("a *a : " + (a * a));
        }
    }
    class der1:base1
    {
        public new void calc()
        {
            base.calc();
            Console.WriteLine("Derived method: ");
            Console.WriteLine("a+a : " + (a + a));
        }
    }
    class override2
    {
        public static void Main()
        {
            der1 d = new der1();
            d.get();
            d.calc();
        }
    }

}
