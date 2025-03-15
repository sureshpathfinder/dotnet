using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class Class3
    {
        public static void Main(string[] ar)
        {
            emp e = new emp();
          //  e.Eid = 12;
            e.Ename = "Sunil";
            Console.WriteLine("Eid : " + e.Eid + "Ename: "+e.Ename);

            


        }
    }
    class emp
    {
        int eid;
        string ename;
        public emp()
        {
            eid++;
        }
        //read only properties
        public int Eid
        {
            get
            {
                return eid;
            }
            //set
            //{
            //    eid = value;
            //}
        }

        //properties
        public string Ename
        {
            get
            {
                return ename;
            }
            set
            {
                ename = value;
            }
        }
    }
}
