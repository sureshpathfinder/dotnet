using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            s.disp();
            s.disp1(3);
            Console.WriteLine("\n NO argument With return type =" + s.disp2());
            Console.WriteLine("\n With argument With return type a=" + s.disp3(4));


        }
    }
    class sample
    {
        //no argument no return type
        public void disp()
        {
            Console.WriteLine("no argument no return type /n ");
        }
        //With argument no return type
        public void disp1(int a)
        {
            Console.WriteLine("With argument no return type  /n");
        }
        //NO argument With return type
        public int disp2()
        {
            return 2;
        }
        //with argument With return type
        public int disp3(int a)
        {
            return a;
        }

    }

}
