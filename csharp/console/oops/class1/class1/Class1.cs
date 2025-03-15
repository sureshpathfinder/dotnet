using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class Class1
    {
        public static void Main()
        { 
            student s1=new student(12,"Gopa");
            //s1.get(12,"Sunil");
            s1.disp();

            student[] s = new student[10];

            s[0] = new student(1, "Sunil");
            s[0].disp();

            s[1] = new student(2, "Ravi");
            s[1].disp();

            s[2] = new student(3, "Dinesh");
            s[2].disp();
        }
    }

  class student
    {
       public int rno;
       public string name;
       public student(int a, string n)
       {
           rno = a;
           name = n;
       }
       //public void get(int r, string n)
       //{
       //    rno = r;
       //    name = n;
       //}
       internal void disp()
        {
            Console.WriteLine("Rno=" + rno);
            Console.WriteLine("name=" + name);
        }
       ~student()
       {
           Console.WriteLine("Deleted");
       }
    }
}
