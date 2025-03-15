using System;
using System.Collections.Generic;
using System.Text;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "HeLLO";
            Console.WriteLine("String s1=" + s1);

            string s2="hello";
            Console.WriteLine("String s2=" + s2);

            //Compare
            Console.WriteLine("Compare s1 and s2=" +String.Compare(s1,s2,true) + "");

            Console.WriteLine("CompareTo  s1 and s2=" +s1.CompareTo(s2)+"");

            //Equals
            Console.WriteLine("Equals of s1 and s2=" + s1.Equals(s2,StringComparison.OrdinalIgnoreCase) + "");

            
            //CopyTo
            //Console.WriteLine("Copy s and s1=" +s.Copy(s1) + "");

            //Replace
            string a = "Good Morning";
            Console.WriteLine("String a=" + a);

            Console.WriteLine("Replace morning into evening=" + a.Replace("Morning","Evening"));

            //Substring
            string a1 = "This is a String";
            Console.WriteLine("String a=" + a1);
            Console.WriteLine("String a="+a1.Substring(4));

            //split
            String a2 = "This is a String";
            Console.WriteLine("String a2=" + a2);
            foreach (string i in a2.Split(' '))
            {
                Console.WriteLine("I=" + i);
            }

            string q = "Welcome";
            Console.WriteLine("String q=" +q);
            Console.WriteLine("Index of  q=" +q.IndexOf('e'));
            Console.WriteLine("LastIndex of  q=" + q.LastIndexOf('e'));

            






        }
    }
}
