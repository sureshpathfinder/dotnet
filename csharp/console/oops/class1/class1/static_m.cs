using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class static_m
    {
        static void Main(string[] args)
        {
            class_n m = new class_n(2,3);
            Console.WriteLine("M object");
            class_n.disp(m);

            class_n m1 = new class_n(4, 5);
            Console.WriteLine("M1 object");
            class_n.disp(m1);

            Console.WriteLine("M object");
            class_n.disp(m);
           
            m.ptt();
        }
       
    }
    class class_n
    {
      static int a;
        int b;
        public class_n(int i,int j)
        {
            a = i;
            b = j;
        }
        public static void disp(class_n m)
        {
            Console.WriteLine("\n a=" + a+ "  B= " +m.b);
            
        }
        public void ptt()
        {
            Console.WriteLine("ptt");
        }

    }

}
