using System;
using System.Collections.Generic;
using System.Text;

namespace delegate2
{
    //delegate declarationfunction
    delegate int DelegateMethod(int a);
    class Program
    {        
        int square(int a)
        {
            return a*a;
        }

        int disp(int m)
        {
            return m;
        }
        
        static void Main()
        {
            Program p=new Program();
            //delegate function reference
            DelegateMethod s=new DelegateMethod(p.square);

            //function calling using delegate
            Console.WriteLine("Square of 2  ="+s(2));

            s=new DelegateMethod(p.disp);
            Console.WriteLine("Print of 5="+s(5));
         }
    }
}
