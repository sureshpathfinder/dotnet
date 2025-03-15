using System;
using System.Collections.Generic;
using System.Text;

namespace inherits1
{
  
    class Program
    {
        static void Main(string[] args)
        {           
            sports sp = new sports(12,"Ravi");            
            sp.getsprt(34, "Cricket");
            sp.disp();
            sp.print();
        }
    }
    class student
    {
         public int rno;
         public string name;         
         public student(int a,string n)
         {
             rno=a;
             name=n;
         }
         public void disp()
         {
             Console.WriteLine("Rno=" + rno);
             Console.WriteLine("name=" + name);
         }
     }
    class sports : student
    {
        public string sprts_name;
        public int score;
        public sports(int a1, String n1): base(a1, n1)
        {
            Console.WriteLine("Derived class");
            
        }  
        public void getsprt(int s, string s_n)
        {
            sprts_name = s_n;
            score = s;           
        }

        public void print()
        {
            disp();
            Console.WriteLine("Sports name=" + sprts_name);
            Console.WriteLine("Score=" + score);
        }
    }
}


