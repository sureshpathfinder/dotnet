using s=System.Console;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
namespace file_strm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string contents = File.ReadAllText("D:\\bsuresh/NEWFILE.txt");
                s.WriteLine("contents = " + contents);
            }
            catch (Exception e)
            {
                s.WriteLine("Error=" + e);
            }
        }
    }
}
