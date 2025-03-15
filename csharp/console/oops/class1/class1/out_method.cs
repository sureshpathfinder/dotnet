using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class out_method
    {
        static void Main(string[] args)
        {
            out_method o = new out_method();
            int x;
            Console.WriteLine(o.square(4, out x));
            Console.WriteLine(x);

            float salary = 23000, tax, pf;
            Console.WriteLine(o.salary_calc(salary, out tax, out pf));
            Console.WriteLine("Salary=" + salary);
            Console.WriteLine("Tax=" + tax);
            Console.WriteLine("Pf=" + pf);
        }
        public string square(int a, out int m)
        {
            m = a * a;
            return "Square=";
         }
        public string salary_calc(float s, out float t, out float pf)
        {
            t = (float)(s * 0.2);
            pf = (float)(s * 0.5);
            return "Salary Details";
        }


    }
}
