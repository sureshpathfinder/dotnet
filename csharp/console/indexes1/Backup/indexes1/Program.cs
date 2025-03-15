using System;
using System.Collections.Generic;
using System.Text;

namespace indexes1
{
    
    class Program
    {
        private string[] a;

        public Program(int size)
        {
            a = new string[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = "empty";
            }
        }

        public string this[int pos]
        {
            get
            {
                return a[pos];
            }
            set
            {
                a[pos] = value;
            }
        }

        static void Main(string[] args)
        {
            int size = 10;

            Program p = new Program(size);

            p[9] = "Some Value";
            p[3] = "Another Value";
            p[5] = "Any Value";

            Console.WriteLine("\nIndexer Output\n");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("p[{0}]: {1}", i, p[i]);
            }
        }
    }
}
