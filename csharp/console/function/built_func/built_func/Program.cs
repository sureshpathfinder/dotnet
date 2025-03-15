using System;
using System.Collections.Generic;
using System.Text;

namespace built_func
{
    class Program
    {
        static void Main(string[] args)
        {
            

            DateTime n = DateTime.Now;
            Console.WriteLine("\n Now   : " + n);

            DateTime a = DateTime.Now;
            Console.WriteLine("\n Add Days: " + a.AddDays(1));

            DateTime dt = new DateTime(2010, 2, 3);

            Console.WriteLine("\n Date: " + dt);

            DateTime n1 = DateTime.Now;

            DateTime d = DateTime.Now;
            Console.WriteLine("\n  Date= " + d);
            Console.WriteLine("\n .Year = " + d.Year);
            Console.WriteLine("\n .Month = " + d.Month);
            Console.WriteLine("\n .Day = " + d.Day);
            Console.WriteLine("\n .Hour = " + d.Hour);
            Console.WriteLine("\n .Minute = " + d.Minute);
            Console.WriteLine("\n .Second = " + d.Second);
            Console.WriteLine("\n .Millisecond = " + d.Millisecond);
            Console.WriteLine("\n .DayOfWeek = " + d.DayOfWeek);

            Console.WriteLine("\n .DayOfYear = " + d.DayOfYear);

            //Console.WriteLine("\n DateTime.IsLeapYear(2012) = " + DateTime.IsLeapYear(2012));

            //// Calculating the tomorrow's date (adding days to the current date.)
         
            //String strDate1 = d.ToString("dd / MM / yy");

            //Console.WriteLine("\n Format dd/MM/yy =" + strDate1);

            DateTime later = DateTime.Now.AddMinutes(60);
            String s = later.ToString("dd / MM / yy, HH : mm ");

            Console.WriteLine("\n  Add Minutes=" + s);

            #region datestring
            DateTime d1 = DateTime.Now;
            Console.WriteLine("\n short date=" + d1.ToShortDateString());
            Console.WriteLine("\n long date=" + d1.ToLongDateString());
            Console.WriteLine("\n short time=" + d1.ToShortTimeString());
            Console.WriteLine("\n long time=" + d1.ToLongTimeString());
            #endregion 
            Console.ReadKey();
        }
    }
}
