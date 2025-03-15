using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace ConsoleApplication4
{
    class MyClass
    {
        public MyClass() { }
        static void process() { }
        public int DoThing(int i, Decimal d, string[] args)
        {
            return 55;
        }
        public int x = 42;
        public float f = 2E10f;
        public double d = 3.14159;
        public string str = "This here's a string";
    }

    public class Demo
    {
        static public void Main222()
        {
            Console.WriteLine("Fields In the Classes......");
            Type t = typeof(MyClass);

            foreach (MemberInfo m in t.GetFields())
            {
                Console.WriteLine("{0}", m);
            }


            Console.WriteLine("Methods In the Classes......");

            foreach (MethodInfo m in t.GetMethods())
            {
                Console.WriteLine("{0}", m);
                foreach (ParameterInfo p in m.GetParameters())
                {
                    Console.WriteLine("Param {0} - {1}", p.ParameterType, p.Name);
                }
            }

        }
    }
}
