using System;
using System.Collections.Generic;
using System.Text;

namespace built_func
{
    class SampleOops
    {
        public static void Main(string[] arg)
        {
            Employee[] e = new Employee[10];

            for (int i = 0; i < 10; i++)
            {
                e[i] = new Employee();
                e[i].GetData(3, "Sunil" + i, 34000);
                e[i].Disp();
            }
           
            Console.ReadKey();
        }
    }

     class Employee
    {
        internal int Eid;
        internal string Ename;        
        internal double Salary;

         internal void GetData(int id, string name, double sal)
        {
            Eid = id;
            Ename = name;
            Salary = sal;
        }
        internal void Disp()
        {
            Console.WriteLine("Employee : " + Eid + " name : " + Ename + " sal " + Salary);
        }
    }
}
