using System;
using System.Collections.Generic;
using System.Text;

namespace class2
{
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student(3,"Construct");
            s.disp();
            Class1 c = new Class1();
            c.m = 2;

        }
    }
    class student
    {
        int rno;
        String name;
        public student(int a, String n)
        {
            name = n;
            rno = a;

        }
        //void get()
        //{
        //    a = 19; 
        //    name = "Sample";
        //}
        internal void disp()
        {
            //get();
            Console.WriteLine("rno" + rno + "name=" + name);
            Console.WriteLine("End of Class");
        }
        ~student()
        {
            Console.WriteLine("Deleted");
        }
    }
}
