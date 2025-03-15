using System;
using System.Collections.Generic;
using System.Text;

namespace inherits1
{
    class Class1
    {
        static void Main(string[] args)
        {
            sports1 sp = new sports1(12, "Ravi");
            sp.getsprt(34, "Cricket");
            sp.disp();
           
        }

    }
    class student1
    {
        public int rno;
        public string name;
        public student1(int a, string n)
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
    class sports1 : student1
    {
        public string sprts_name;
        public int score;
        public sports1(int a1, String n1): base(a1, n1)
        {
            Console.WriteLine("Derived class");

        }
        public void getsprt(int s, string s_n)
        {
            sprts_name = s_n;
            score = s;
        }

        public new void disp()
        {
            base.disp();
            Console.WriteLine("Sports name=" + sprts_name);
            Console.WriteLine("Score=" + score);
        }
    }
}
