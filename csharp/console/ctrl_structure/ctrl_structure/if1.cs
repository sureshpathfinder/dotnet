using System;
using p = System.Console;
using System.Collections.Generic;
using System.Text;

namespace ctrl_structure
{
    class if1
    {
        static void Main()
        {
            int i = 24;
           
            if (i>23)
                p.WriteLine("Welcome");
            else
                p.WriteLine("Else statement");
            Console.ReadKey();
        }
    }
}
