using System;
using System.Collections.Generic;
using System.Text;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Hello";
            Console.WriteLine("String s=" + s);

            String s1="Welcome";
            Console.WriteLine("String s1=" + s1);

            //Compare

            Console.WriteLine("Compare s and s1=" + s.CompareTo(s1)+"");

            //Equals
            Console.WriteLine("Equals of s and s1=" + s.Equals(s1) + "");

            //CopyTo
            Console.WriteLine("Copy s and s1=" + s.CopyTo(s1) + "");

            //Replace
            String a = "Good Morning";
            Console.WriteLine("String a=" + a);

            Console.WriteLine("Replace morning into evening=" + a.Replace("Morning","evening"));

            //Substring
            String a1 = "This is a String";
            Console.WriteLine("String a=" + a1);
            Console.WriteLine("String a="+a1.Substring(4,6));

            //split
            String a2 = "This is a String";
            Console.WriteLine("String a2=" + a2);
            foreach (String i in a2.split(" "))
            {
                Console.WriteLine("I=" + i);
            }

            String q = "Welcome";
            Console.WriteLine("String q=" +q);
            Console.WriteLine("Index of  q=" +q.IndexOf('e'));
            Console.WriteLine("Index of  q=" + q.LastIndexOf('e'));

            






        }
    }
}
