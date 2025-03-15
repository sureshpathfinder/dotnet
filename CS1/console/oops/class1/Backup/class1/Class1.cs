using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class Class1
    {
        public static void Main()
        { 
            student s1=new student(1,"Ravi");
            s1.disp();


            student[] s=new student[10];

            s[0]=new student(1,"Sunil");
            s[0].disp();

            s[1] = new student(2, "Ravi");
            s[1].disp();
            
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
        public void disp()
        {
            Console.WriteLine("Rno=" + rno);
            Console.WriteLine("name=" + name);
        }
    }
}
