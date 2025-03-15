using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Thread t = new Thread(new ThreadStart(p.disp));
            Thread t1 = new Thread(new ThreadStart(p.disp));
            t.Name = "First ";
            t1.Name = "Second ";           
            
            Console.WriteLine("Thread is now started");
            t.Start();
            try
            {
                Console.Write("start");
               //t.Suspend();

                t.Priority = ThreadPriority.Highest;
                t1.Priority = ThreadPriority.Lowest;
                t1.Start();
                Console.WriteLine("Thread state=" + t.ThreadState);
                Console.WriteLine("Thread is suspended");
               if(t.ThreadState== ThreadState.Suspended)
                    t.Resume();
               if (t1.ThreadState == ThreadState.Suspended)
                   t1.Resume();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            Console.ReadKey();
        }
     
 
         void disp()
        {      
            for (int i = 1; i <= 50; i++)
            {
                String a = Thread.CurrentThread.Name;
                Console.WriteLine(a + "  " + i + "  ");
                if (i == 20)
                {
                    Thread.CurrentThread.Suspend();
                    Console.WriteLine("The thread is in suspend state : " + Thread.CurrentThread.ThreadState);
                   
                }
               
                Thread.Sleep(1000);
            }              
        }
    }


 }

