using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ConsoleApplication2
{
    delegate void MyDelegate(string s);

    class MyClass
    {
        public static void Hello(string s)
        {
            Console.WriteLine("  Hello, {0}!", s);
        }
        public static void Goodbye(string s)
        {
            Console.WriteLine("  Goodbye, {0}!", s);
        }

        public static void callDelegate(MyDelegate m)
        {
            m("X");
        }
        public static void Main()
        {
            MyDelegate a, b;

            a = new MyDelegate(Hello);
            b = new MyDelegate(Goodbye);


            Console.WriteLine("Before Delegate Call");
            a("jhon");
            b("jhon");

            callDelegate(a);
            callDelegate(b);

            //Multi Cast Delegate
            a += b;

            a("xyz");

        }
    }
}


