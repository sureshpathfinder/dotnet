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
         //  File.Create("D:\\SSI_Suresh\\sample.txt");
            string contents = File.ReadAllText("D:\\SSI_Suresh\\sample.txt");
            Console.WriteLine("contents = " + contents);
          //string x = Console.ReadLine();
           // File.WriteAllText("D:\\SSI_Suresh\\sample.txt",x);
            //File.AppendAllText("D:\\SSI_Suresh\\sample.txt", x);
            Console.WriteLine("File is Created");
          //  File.Copy("D:\\SSI_Suresh\\sample.txt", "D:\\SSI_Suresh\\desg.txt");
            

        }
    }
}
