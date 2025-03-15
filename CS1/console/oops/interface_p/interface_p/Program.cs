using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_p
{
    class Program
    {
       public static void Main(string[] args)
        {
            samp s= new samp();
            s.disp1();
            s.disp2();
        }
    }
    interface test1
    {
        void disp1();
    }
    interface test2
    {
        void disp2();
    }
    class samp : test1, test2
    {
        public void disp1()
        {
            Console.WriteLine("test1 method");
        }

        public void disp2()
        {
            Console.WriteLine("Test 2 method");
        }
    }

}
