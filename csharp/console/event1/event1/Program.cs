using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace event1
{
    class Program
    {
        static void Main(string[] args)
        {
            emp e = new emp();

            e.Ename = "Sunil";

            // subscribe the event
            e.changeevent += new emp.del_ename(e_changeevent);
            Console.WriteLine("Ename: " + e.Ename);   
 
            e.Ename = "ram";
            e.Ename = "dsjk";
            e.Ename = "fdjhfj";
        }

        static void e_changeevent(string s)
        {
            Console.WriteLine("Ename name changed:" + s);
        }


       
    }
    class emp
    {
       string ename;
        public string Ename
        {
            get
            {
                return ename;
            }
            set
            {
                ename = value;

                //3) Invoking the event
                if(changeevent!=null)
                    changeevent(ename);
            }
        }
        //1) delegate declaration
        public delegate void del_ename(string s);

        //2)Event declaration
        public event del_ename changeevent;
    }
}
