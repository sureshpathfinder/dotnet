using x=System.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace ctrl_structure
{
    class uncond1
    {
        static void Main(string[] ar)
        {

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)  
                    continue;
                // System.Environment.Exit(0);
                x.Write(i + " ");
            }
            x.WriteLine("End");
        }
    }
}
