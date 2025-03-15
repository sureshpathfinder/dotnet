using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //sample s = new sample();
            //Console.WriteLine("Square=" + s.disp(2));
            //Console.WriteLine("Cube=" + s.print(2));

        }
    }
    interface square
    {
        int disp(int a);
    }
    interface cube
    {
        int print(int a);
    }
    class sample 
    {
        int disp(int a)
        {
            return a * a;
        }
        int print(int a)
        {
            return a * a * a;
        }
    }

}
