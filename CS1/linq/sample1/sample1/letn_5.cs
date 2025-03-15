using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sample1
{
    class letn_5
    {
        public static void Main(string[] ar)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            string[] s = { "zero","one", "two", "three", "four", "five", "six" };
            var x = from n in a where n>=5 select s[n];
            foreach (var i in x)
                Console.WriteLine(i);
        

        }
    }
}
