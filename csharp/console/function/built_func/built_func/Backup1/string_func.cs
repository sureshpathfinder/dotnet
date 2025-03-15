using System;
using System.Collections.Generic;
using System.Text;

namespace built_func
{
    class string_func
    {
        static void Main(string[] args)
        {
            String sc = "welcome";
            Console.WriteLine("\n String class :" + sc);
            string s1, s2,s3,s4,m;
            s1 = "welcome to string";


            Console.WriteLine("\n s1.Contains('to') "+ s1.Contains("to"));
            m = "Second string";
            Console.WriteLine("\n String.Concat(s1, m) :  " +String.Concat(s1, m));
            
               Console.WriteLine("\n S1=" + s1);
            Console.WriteLine("\n s1.IndexOf(\"e\") ="+s1.IndexOf("e"));
            Console.WriteLine("\n  s1.LastIndexOf(\"e\")=" + s1.LastIndexOf("e"));
            Console.WriteLine("\n s1 UPPER CASE=" + s1.ToUpper());
            Console.WriteLine("\n s1 Lower CASE=" + s1.ToLower());

            s2 = "Hello Welcome";

            Console.WriteLine("\n s2 Substring=" + s2.Substring(6,3));
            
            s3 = "hello";
            s4 = "HELLO";

            int result = string.Compare(s3, s4,true);
            Console.WriteLine("\n Compare Result=" + result);

            bool r = string.Equals(s3, s4,StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("\n Equals Result=" + r);
            
            double dNum = 32.123456789;
            Console.WriteLine("\n Format=" + string.Format("{0:n2}", dNum));

            string s = "       hello   ";
            Console.WriteLine("\n trim of s= "+s.Trim());

            string l= "good morning";
            Console.WriteLine("\n s.startswith(g)= " + l.StartsWith("g"));
            Console.WriteLine("\n s.Endswith(g)= " + l.EndsWith("g"));
            
            Console.WriteLine("\n s.Replace(\"morning\",\"evening\")= " + l.Replace("morning","evening"));

            string sp = "welcome to split string";
            Console.WriteLine("\n sp="+sp);

            foreach (string x in sp.Split(' '))
                    Console.WriteLine("\n x =" + x);

            string a = "welcome to csharp";
            Console.WriteLine("a.Substring(3, 5) : " +a.Substring(3, 5));
        }   
    }
}
