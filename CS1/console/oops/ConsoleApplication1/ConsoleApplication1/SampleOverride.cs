using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class SampleOverride
    {
        public static void Main(string[] arg)
        {
            PermanentEmployee e = new PermanentEmployee();
            e.SalaryCalc(23000);
            Console.ReadKey();
        }

    }

    class Employee
    {
        internal void SalaryCalc(int salary)
        {
            Console.WriteLine("salary :" + (salary));
            Console.WriteLine("PF :" + (salary * .2));
        }
    }

    class PermanentEmployee : Employee
    {
        internal override void SalaryCalc(int salary)
        {
            base.SalaryCalc(salary);
            Console.WriteLine("medicline: " + (salary * 0.5));
        }
    }
}
