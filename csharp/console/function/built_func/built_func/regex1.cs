using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace built_func
{
    class regex1
    {
        public static void Main(string[] ar)
        {
        x:
            Console.WriteLine("Enter email id:");
            string a = Console.ReadLine();
            var r = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (r.IsMatch(a))
                 Console.WriteLine("Email : " + a);
            else
                goto x;
               
        }

    }
}
