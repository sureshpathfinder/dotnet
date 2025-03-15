using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication2
{
    //delegate declaration
    delegate void meth_del(string n);
    class Class1
    {
        public void disp(string s)
        {
            Console.WriteLine("disp string=" + s);

        }
        public void show(string s)
        {
            Console.WriteLine("show string=" + s);

        }
        public static void Main(string[] ar)
        {
            Class1 c=new Class1();
            //delegate function reference
            meth_del d = new meth_del(c.disp);
            //delegate function calling
            d("disp method call by delegate");

            d = new meth_del(c.show);
            d("show method");
        }
    }
}
