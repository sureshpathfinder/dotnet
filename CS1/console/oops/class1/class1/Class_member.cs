using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
     class Class_member
    {
        static void Main(string[] args)
        {

            sample1 s = new sample1();
            s.disp();
            s.disp1(3);
            Console.WriteLine("\n NO argument With return type =" + s.disp2());
            Console.WriteLine("\n With argument With return type a=" + s.disp3(4));
            Class_member c = new Class_member();
            c.prr();

        }
        public void prr()
        {
            Console.Write("hello prr");
        }
    }
    class sample1
    {

        //no argument no return type
        public void disp()
        {
            Console.WriteLine("no argument no return type /n ");
        }
        //With argument no return type
        public void disp1(int a)
        {
            disp();
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
