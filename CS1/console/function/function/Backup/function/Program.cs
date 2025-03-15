using System;
using System.Collections.Generic;
using System.Text;

namespace function
{
   
    class Program
    {
        public static void Main(string[] args)
        {
            student s = new student();
            s.disp();
      
            Console.WriteLine("value=" + s.print());
            Console.WriteLine("Addition=" + s.add(2,5));
            Console.WriteLine("Square=" + s.square(2));
            Console.WriteLine("Factorial of 4=" + s.fact(4));
            Program p = new Program();
            p.sam1();
            
         }
       void SAM()
        {
            Console.Write("SAM");
        }
        public void sam1()
        {

            SAM();
        }
    }
    
    
}
