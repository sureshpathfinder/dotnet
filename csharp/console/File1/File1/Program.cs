using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace File1
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter str = new StreamWriter("d:/bsuresh/am.text",true);
            str.WriteLine("Welcome");
            str.WriteLine("To");
            str.WriteLine("C#");
            str.Close();
        }
    }
}
