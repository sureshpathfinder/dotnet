using System;
using c = System.Console;
using System.Collections.Generic;
using System.Text;

namespace built_func
{
    class math_func
    {
        static void Main(string[] args)
        {
            c.WriteLine("Math Function");
            c.WriteLine("Sin" + Math.Sin(30));
            c.WriteLine("Sqrt of 81=" + Math.Sqrt(81));
            c.WriteLine("4 power 3=" + Math.Pow(4,3));
            c.WriteLine("Round off=" + Math.Round(0.0125489));
            c.WriteLine("Ceil off=" + Math.Ceiling(0.01));
            c.WriteLine("Floor off=" + Math.Floor(2.999));

            c.WriteLine("Absolute" + Math.Abs(-45));
            c.WriteLine("Max=" + Math.Max(45,34));
        }
    }
}
