using System;
using System.Collections.Generic;


namespace class1
{
    class set_get1
    {
        public static void Main()
        {
            MyClass m = new MyClass();
            m.h = 10;
            m.disp();                
            int x = m.h;
            Console.WriteLine("a="+x);//Displays 10
        }
    } 
    class MyClass
    {
        private int a;
        public int h
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public void disp()
        {
            a++;
        }
    }
    
}
