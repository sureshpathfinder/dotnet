using System;
using System.Collections.Generic;
using System.Text;

namespace interface1
{
    interface IPoint
    {
        // Property signatures:
        int x
        {
            get;
            set;
        }
       void disp();
    }

    class Point : IPoint
    {
        private int a;        
        
        public int x
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }
        public void disp()
        {
            Console.Write("Interface Disp: ");
        }
    }

    class MainClass
    {
        
        static void Main()
        {
            Point p = new Point();
            Console.Write("My Point: ");
            p.x = 3;
            Console.WriteLine("x="+p.x);
            p.disp();
            //PrintPoint(p);
        }
    }

}
