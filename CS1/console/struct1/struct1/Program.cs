using System;
using System.Collections.Generic;
using System.Text;

namespace struct1
{
   class Program
        {
            static void Main(string[] args)
            {
                student s = new student(1,"Ravi");              
                //s.getd(1, "Ravi");
                s.disp();
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
                public void getd(int r, string n)
                {
                    rno = r;
                    name = n;
                }
                public void disp()
               {     
                    Console.WriteLine("rno=" + rno + "  name=" + name);
                    Console.ReadKey();
                }
                
                //~student()
                //{
                //    Console.WriteLine("Destructor");
                //}
             
            }
        }
    }   
