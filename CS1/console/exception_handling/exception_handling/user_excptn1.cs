using System;
using System.Collections.Generic;
using System.Text;

namespace exception_handling
{
    class marks:Exception
    {
        private int m;
        public marks(int a) 
        {
            m = a;
        }
        public override String ToString()
        {
            return "MyException :" + m +"  it should between 0 to 100 ";
        }
    }
    class user_excptn1
    {
        static void Main()
        {
            //int? x = null;
            //double d = Double.NaN;
            //Console.WriteLine(x);
            Console.WriteLine("Enter the value: ");
            int? a = Convert.ToInt32(Console.ReadLine());
            
            if ((a<0)||(a>100)|| a==null)
                try
                {
                    throw new marks((int)a);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception caught here  :  " +e);
                }
            Console.WriteLine("LAST STATEMENT marks: "+ a);
            Console.ReadKey();
        }
    }    


}
