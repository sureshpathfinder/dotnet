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
            
            //lock (t)
            //{
               Monitor.Enter(t);
                t.Start();
                //Monitor.Pulse(t);
                Monitor.PulseAll(t);
                //Monitor.Wait(t);
               // t.Suspend();
                //Console.WriteLine("Thread state"+t.ThreadState);

               // t.Resume();
                Monitor.Exit(t);
            //}

            t1.Priority = ThreadPriority.Highest;
            //lock (t1)
            //{
                t1.Start();
            //}

            Console.ReadKey();
        }


        void disp()
        {
            lock (this)
            {
                for (int i = 1; i <=50; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "  " + i + "  ");
                    Thread.Sleep(1000);
                }
            }
        }
    }
              
 }

