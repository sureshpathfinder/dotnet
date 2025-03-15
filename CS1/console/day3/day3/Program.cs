using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ConsoleApplication1
{
    class Program
    {
        public  static void Main(string[] args)
        {
            Company c = new Company();

            Employee e1 = new Employee();
            e1.Eid = 11;
            e1.Name = "Sunil";
            Employee e2 = new Employee();
            e2.Eid = 12;
            e2.Name = "Ram";
            c.Employees.Add(e1);
            c.Employees.Add(e2);

            c.Doprocess(new ProcessEmployee(c.Printid));
            c.Doprocess(new ProcessEmployee(c.PrintName));

            Timer t = new Timer(2000);
            t.Elapsed += new ElapsedEventHandler(t_Elapsed);
           
            t.Start();

            t.Elapsed -= new ElapsedEventHandler(t_Elapsed);
            Console.ReadKey();
            
        }

        static void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            Console.WriteLine("welcome");
        }        
    }
    public delegate void ProcessEmployee(Employee e);

    class Company
    {
        private List<Employee> employees;

        public void Printid(Employee e)
        {
            Console.WriteLine("Eid: " + e.Eid);
        }
        public void PrintName(Employee e)
        {
            Console.WriteLine("Name: " + e.Name);
        }
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        public Company()
        {
            employees = new List<Employee>();
        }
        public void Doprocess(ProcessEmployee processemp)
        {
            foreach (Employee employee in employees)
            {
                processemp(employee);
            }           
        }

    }

   

    public class Employee
    {

        private int eid;

        public int Eid
        {
            get { return eid; }
            set {
                try
                {
                    eid = value;
                 
                }
                catch (Exception)
                {
                }
            }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        
    }
}
