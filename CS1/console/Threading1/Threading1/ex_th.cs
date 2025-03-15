﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Threading1
{
    class ex_th
    {
        public static void Main(string[] args)
        {
            sample s = new sample();
          
            Thread t1 = new Thread(new ThreadStart(s.disp));
            t1.Start();
            t1.Name = "First Thread";
            t1.Priority = ThreadPriority.Highest;

            Thread t2 = new Thread(new ThreadStart(s.disp));
            t2.Start();
            t2.Name = "second";
            t2.Priority = ThreadPriority.Lowest;
            Console.ReadKey();
        }
    }
    class sample
    {
        public void disp()
        {
            for (int i = 1; i < 100; i++)
            {
              // Thread.Sleep(1000);
             //   Thread.CurrentThread.Suspend();
               Console.WriteLine("Disp: "+ i + " , " + Thread.CurrentThread.Name);
               
            }
        }
        public void show()
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine("show: " + i);
            }
        }
    }
}
