using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class PropSample
    {
        public static void Main(string[] arg)
        {
            Emp e = new Emp();
          //  e.Eid = 43;
            Console.WriteLine(e.Eid);

            Emp e1 = new Emp();
            //  e.Eid = 43;
            Console.WriteLine(e1.Eid);
            Console.ReadKey();
        }
    }

    class Emp
    {
        private int eid;

        static int c= 0;

        internal Emp()
        {
            eid = ++c;
        }
        public int Eid
        {
            get { return eid; }
            //set { eid = value;
            //Disp("eid changed");
            //}
        }

        internal void Disp(string c)
        {
            Console.WriteLine(c + " " + eid);
        }
        
    }
}

