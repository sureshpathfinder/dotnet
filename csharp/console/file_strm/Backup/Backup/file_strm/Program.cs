using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace file_strm
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = File.ReadAllText("D:\\bsuresh/NEWFILE.txt");
            Console.Out.WriteLine("contents = " + contents);

        }
    }
}
