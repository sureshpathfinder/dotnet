using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
           
    //        sports sp = new sports();
    //        sp.getsprt(34, "Cricket",2);
    //        sp.print();


    //    }
    //}
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
    //class sports : student
    //{
    //    public string sprts_name;
    //    public int score,wicket;
    //    public void getsprt(int s, string s_n,int w)
    //    {
    //        sprts_name = s_n;
    //        score = s;
    //        wicket = w;
    //    }

    //    public void print()
    //    {
    //        disp();
    //        Console.WriteLine("Sports name=" + sprts_name);
    //        Console.WriteLine("Score=" + score);
    //    }
    //}
}
