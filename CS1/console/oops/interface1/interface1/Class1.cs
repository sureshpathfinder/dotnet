using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{

    interface inter11
    {
        int disp1(int a);    
    }

    interface inter21
    {
        int disp2(int a);
        void print();
    }
  
  

    class samp : inter21, inter11
    {
        static void Main()
        {
            samp s = new samp();
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
