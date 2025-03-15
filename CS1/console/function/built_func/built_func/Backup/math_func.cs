using System;
using System.Collections.Generic;
using System.Text;
using System.Math;


namespace built_func
{
    class math_func
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Function");
            Console.WriteLine("Sin" + Math.Sin(30));
            Console.WriteLine("Sqrt of 81" + Math.Sqrt(81));
            Console.WriteLine("4 power 3=" + Math.Pow(4,3));
            Console.WriteLine("Round off=" + Math.Round(.125489));
            Console.WriteLine("Ceil off=" + Math.Ceiling(.1));
            Console.WriteLine("Floor off=" + Math.Floor(.9));


            Console.WriteLine("Absolute" + Math.Abs(-45));
            Console.WriteLine("Absolute" + Math.Max(45,34));
        }
    }
}
