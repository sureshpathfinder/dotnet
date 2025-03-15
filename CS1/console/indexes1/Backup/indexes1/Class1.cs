using System;
using System.Collections.Generic;
using System.Text;

namespace indexes1
{
    class Class1
    {
        private string[] items;
        public Class1(int size)
        {
            items = new string[size];
        }

        public string this[int s]
        {
            get
            {
                return items[s];
            }
            set
            {
                items[s] = value;
                
            }
        }
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c[0] = "hello";
            c[1] = "welcome";
            Console.WriteLine(c[0]);
            Console.WriteLine(c[1]);
        }
    }
}
