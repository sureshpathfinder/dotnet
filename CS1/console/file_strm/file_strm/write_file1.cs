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
            FileStream fs = new FileStream("D:\\SSI_Suresh\\sample.txt", FileMode.OpenOrCreate, FileAccess.Write);			
            StreamWriter sw = new StreamWriter(fs);
            
            string s ;
            Console.WriteLine("Enter the data: ");
            while ((s = Console.ReadLine()) != null)
            {
                sw.WriteLine(s);
            }
            Console.WriteLine("Content written successfully.");
            
            sw.Close();
            fs.Close();
        }
    }
}
