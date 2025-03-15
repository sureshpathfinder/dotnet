using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading1
{
    class Class1
    {
        static void Main(string[] args)
        {
            Class1 p = new Class1();
            Thread t = new Thread(new ThreadStart(p.disp));
            Thread t1 = new Thread(new ThreadStart(p.disp));
            t.Name = "A";
            t1.Name = "G";
            t.Priority = ThreadPriority.Lowest;

            lock (t)
            {
                t.Start();
            }

            t.Suspend();

            t1.Priority = ThreadPriority.Highest;
            lock (t1)
            {
                t1.Start();
            }

            Console.WriteLine("Thread state=" + t.ThreadState);
            Console.WriteLine("Thread is suspended");

            t.Resume();

            Console.ReadKey();



        }


        void disp()
        {

            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "  " + i + "  ");
                    Thread.Sleep(1000);
                }
            }
        }
    }
              
 }

