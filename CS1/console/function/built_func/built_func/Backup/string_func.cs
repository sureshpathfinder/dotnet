using System;
using System.Collections.Generic;
using System.Text;

namespace built_func
{
    class string_func
    {
        static void Main(string[] args)
        {
            string s1, s2,s3,s4;
            s1 = "Hello";
            Console.WriteLine("S1=" + s1);
            Console.WriteLine("S1=" + s1.LastIndexOf("l"));
            Console.WriteLine("s1 UPPER CASE=" + s1.ToUpper());
            Console.WriteLine("s1 UPPER CASE=" + s1.ToLower());

            s2 = "Hello Welcome";
            Console.WriteLine("s2 Substring=" + s2.Substring(3,4));
            
            s3 = "welcome";
            s4 = "WELCOME";

            int result = string.Compare(s3, s4,true);
            Console.WriteLine("Result=" + result);

            bool r=string.Equals(s3,s4);
             Console.WriteLine("Result=" + r);
            

            double dNum = 32.123456789;
            Console.WriteLine("Format=" + string.Format("{0:n2}", dNum));
            



          
        }   
    }
}
