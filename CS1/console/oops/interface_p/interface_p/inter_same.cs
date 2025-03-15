using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_p
{
    class inter_same
    {
        public static void Main(string[] args)
        {
            itest1 t1 = new sample();
            t1.disp();
            itest2 t2 = new sample();
            t2.disp();
        }
    }
    interface itest1
    {
        void disp();
        void show();
    }
    interface itest2
    {
        void disp();
    }
    class sample : itest1, itest2
    {

        void itest1.disp()
        {
            Console.WriteLine("Itest1 disp method");
        }

        void itest2.disp()
        {
            Console.WriteLine("Itest2 disp method");
        }
        //public void show()
        {
            Console.WriteLine("show");
        }
    }
}
