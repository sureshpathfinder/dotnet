using System;
using System.Collections.Generic;
using System.Text;

namespace struct1
{
    class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.eid = 1;
            e.name = "ravi";
            Console.WriteLine("Eno=" + e.eid);
            Console.WriteLine("Ename=" + e.name);


        }
    }
    struct employee
    {
        public int eid;
        public String name;
    }

}
