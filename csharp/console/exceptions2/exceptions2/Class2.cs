using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class2
    {
        public static void Main(string[] ar)
        {
            try
            {
                Console.WriteLine("Enter age: ");
                int age = int.Parse(Console.ReadLine());
                if ((age > 100) || (age < 0))
                    throw new ageexception(age);
                Console.WriteLine("Age  : " + age);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    class ageexception : Exception
    {
        int a;
        public ageexception(int x)
        {
            a = x;
        }
        public override string ToString()
        {
            return "Age should not be valid" + a;
        }
    }
}
