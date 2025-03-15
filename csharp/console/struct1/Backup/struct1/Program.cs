using System;
using System.Collections.Generic;
using System.Text;

namespace struct1
{
   class Program
        {
            static void Main(string[] args)
            {
                student s = new student(2,"Construct");
                s.disp();
            }
            struct student
            {
                int rno;
                String name;
                public student(int a,String n)
                {
                    name = n;
                    rno = a;                    
                }
                //void get()
                //{
                //    rno = 2;
                //    name = "ravi";
                //}
                public void disp()
                {
                    //get();

                    Console.WriteLine("rno" + rno + "name=" + name);
                }
                //~student()
                //{
                //    Console.WriteLine("Deleted");
                //}
            }
        }
    }   
