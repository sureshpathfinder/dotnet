using System;
using System.Collections.Generic;
using System.Text;

namespace struct1
{

    class st_func
    {
        static void Main(string[] args)
        {
            student s = new student();


            s.disp();
        }
        struct student
        {
            int rno;
            String name;
            void get()
            {
                rno = 2;
                name = "ravi";
            }
            public void disp()
            {
                get();

                Console.WriteLine("rno" + rno + "name=" + name);
            }
        }
    }
}

