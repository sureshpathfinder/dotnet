using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace file_strm
{
    class streamcs1
    {
        static void Main(string[] args)
        {

            StreamWriter str = new StreamWriter("d:/bsuresh/am.text",false);
            str.WriteLine("Welcome");
            str.WriteLine("To");
            str.WriteLine("C#");
            str.Close();
        }
    }
}
