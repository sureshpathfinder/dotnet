using System;
using System.Collections.Generic;
using System.Text;

namespace ctrl_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks ;
            marks= int.Parse(Console.ReadLine());
            //Boolean b = true;
            if (marks >=80)
            {
                Console.WriteLine("Distinction");
            }
            else if (marks>=60)
            {
                Console.WriteLine("First Class");
            }
            else if (marks >=40)
            {
                Console.WriteLine("Pass");
            }
            else Console.WriteLine("Fail");

            Console.ReadKey();

        }
    }
}
