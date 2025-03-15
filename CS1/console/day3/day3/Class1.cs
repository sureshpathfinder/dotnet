using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ConsoleApplication1
{
    class Class1
    {
        public static void Main(string[] ar)
        {
            Timer t = new Timer(1000);
            t.Elapsed += new ElapsedEventHandler(t_Elapsed);
            t.Start();

            Console.ReadKey();
        }

        static void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Event called:");
        }
    }
}
