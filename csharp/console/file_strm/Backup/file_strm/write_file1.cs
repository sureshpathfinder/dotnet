using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace file_strm
{
    class write_file1
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("D:/bsuresh/NEWFILE2.txt",FileMode.OpenOrCreate, FileAccess.Write);			
            StreamWriter sw = new StreamWriter(fs);
            
            string s = Console.ReadLine();
            
            sw.WriteLine(s);
          

            sw.WriteLine("Hello World.");
            
            sw.Close();

            fs.Close();
        }
    }
}
