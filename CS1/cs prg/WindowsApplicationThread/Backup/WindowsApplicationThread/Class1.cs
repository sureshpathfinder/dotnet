using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
namespace WindowsApplicationThread
{
    public class Class1
    {
        private int Runs = 0;
       
        public void CountUp()
        {
            while (Runs < 10)
            {
             // Monitor.Enter(this);
                int Temp = Runs;
                Temp++;
                Console.WriteLine(Thread.CurrentThread.Name + " " + Temp);
                Thread.Sleep(1000);
                Runs = Temp;
              //Monitor.Exit(this);
            }
        }
        public void RunThreads()
        {
            Thread t1 = new Thread(new ThreadStart(CountUp));
            t1.Name = "t1";
            Thread t2 = new Thread(new ThreadStart(CountUp));
            t2.Name = "t2";

            t1.Start();
            t2.Start();

        }
    }
}
