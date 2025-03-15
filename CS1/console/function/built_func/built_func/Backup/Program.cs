using System;
using System.Collections.Generic;
using System.Text;

namespace built_func
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime n= DateTime.Now;
            Console.WriteLine("Now   : "+ n);
            
            DateTime a = DateTime.Now.AddDays(2);
            Console.WriteLine("Add Hours: "+a);
            DateTime dt = new DateTime(2001,10,11);

            Console.WriteLine("Date: "+dt);

            TimeSpan oneWeek = new TimeSpan(4, 12, 0, 20) ;

            DateTime n1 = DateTime.Now;

            
            DateTime past = n1 - oneWeek;

           Console.WriteLine("Past  : {0}", past);

            DateTime d=DateTime.Now;
            Console.WriteLine( " Date= " + d);
            Console.WriteLine(".Year = " + d.Year);
            Console.WriteLine(".Month = " + d.Month);
            Console.WriteLine(".Day = " + d.Day);
            Console.WriteLine(".Hour = " + d.Hour);
            Console.WriteLine( ".Minute = " + d.Minute);
            Console.WriteLine(".Second = " + d.Second);
            Console.WriteLine( ".Millisecond = " + d.Millisecond);

            Console.WriteLine("DateTime.IsLeapYear(2004) = " + DateTime.IsLeapYear(2004));

            // Calculating the tomorrow's date (adding days to the current date.)
            DateTime tomorrow = DateTime.Today.AddDays( 1 );               String strDate = tomorrow.ToString("dd / MM / yy");

// Calculating the yesterday's date (substracting days from current date.)
            DateTime yesterday = DateTime.Today.AddDays( -1 );             String strDate = yesterday.ToString("dd / MM / yy");



            DateTime later = DateTime.Now.AddMinutes( 60 );
            String  s= later.ToString("dd / MM / yy, hh : mm ");
            
            Console.ReadKey();
            


        }
    }
}
