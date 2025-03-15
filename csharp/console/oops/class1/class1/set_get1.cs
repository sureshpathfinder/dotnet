using System;
using System.Collections.Generic;


namespace class1
{
    class set_get1
    {
        public static void Main()
        {
            properties1  m = new properties1();
           m.h = 10;                
            int x = m.h;
            Console.WriteLine("a="+x);//Displays 10
            Console.Read();
        }
    } 
    
}
