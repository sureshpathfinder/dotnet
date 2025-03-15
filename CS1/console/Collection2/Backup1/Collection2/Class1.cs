using System;
using System.Collections.Generic;
using System.Text;

namespace Collection2
{
    class Class1
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> s = new Dictionary<int, string>();

            s.Add(1,"Item one");
          //  s.Add("1", "value");
            s.Add(2,"Item Two");
            s.Add(3,"Item 3");

            foreach(KeyValuePair<int, string> d in s)
            {
                Console.WriteLine(
                    " ID: {0}, Name: {1}",
                    d.Key,
                    d.Value);
            }

            Console.ReadKey();
        }
    }
}
