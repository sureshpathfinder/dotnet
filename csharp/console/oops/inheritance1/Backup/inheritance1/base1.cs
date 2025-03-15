using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance1
{
    class base1
    {
        public static void Main()
        {
            child b = new child(2, 4);
            b.show();
        }


    }
    class parent1
    {
        public int a;
        public parent1(int x)
        {
            a = x;
            Console.WriteLine("Class a");
        }
        public void disp()
        {
            Console.WriteLine("Base Method");
        }
    }
    class child : parent1 
    {
        public int a;
        public child(int i,int j):base(i)
        {
            
            a = j;
            Console.WriteLine("a=" + base.a);
            Console.WriteLine("a=" + a);
        }
        public void show()
        {
            base.disp();
        }
    }
}
