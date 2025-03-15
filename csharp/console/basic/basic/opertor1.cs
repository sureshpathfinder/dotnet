using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class opertor1
    {
        public static void Main(string[] args)
        {
            
            int a=5,b=12,c;
            c = a % b;
            Console.WriteLine(" c= " + c);
       
           
            //contional
            Console.WriteLine("Greatest value :" + ((a > b) ? a : b));


            ////increment
            Console.WriteLine(" ++a  :  "+ (++a)+ "   a:  " +a+ "  a++ :"+ (a++));
            Console.WriteLine(" a= " + a);
            Console.ReadKey();
            ///
        }
       
   
    }
}
