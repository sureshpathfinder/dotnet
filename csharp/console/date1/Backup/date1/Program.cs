using System;
using System.Collections.Generic;
using System.Text;

namespace date1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            Console.WriteLine("Date=" + d.DayOfWeek);

           
            Console.WriteLine("Reneval date=" + d.AddDays(12));

            DateTime a1 = new DateTime(4/23/2010);
            DateTime a2 = new DateTime(2004, 1, 14);
            Console.WriteLine("a1 = " + a1);
            Console.WriteLine("a2 = " +a2.ToLongDateString());
            int i= DateTime.Compare(a1,a2);

            Console.WriteLine("Day difference" + i);

        }
    }
}
