using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{

    interface inter1
    {
        int disp1(int a);       

    }

    interface inter2
    {
        int disp2(int a);
        void print();
    }

    class sample : inter2, inter1
    {
        static void Main()
        {
            sample s = new sample();
            Console.WriteLine("square=" + s.disp1(2));
            Console.WriteLine("Cube =" + s.disp2(2));
            s.print();
            
        }

        public int disp2(int a)
        {
           
           // Console.WriteLine("disp2() called.");
            return  a * a * a;
        }

        public int disp1(int a)
        {
           // Console.WriteLine("disp1() called.");
            return a * a;
        }
        public void print()
        {
            Console.WriteLine("End of program");
        }   

    }
}
