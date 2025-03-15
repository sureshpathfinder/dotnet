using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace file_strm
{
    class filez1
    {
        public static void Main(string[] ar)
        {


            string[] s = { "hello", "welcome", "\n" };

            File.Create("c:\\wamp\\myfile.doc");



            string t=File.GetCreationTime("E:\\newfile.txt").ToString();

            Console.WriteLine("Creation date=" + t);
           // File.WriteAllLines("E:\\newfile.txt",s);

           string[] x= File.ReadAllLines("E:\\newfile.txt");


            for(int i=0;x[i]!=null;i++)
                Console.WriteLine("File data=" + x[i]);

            Console.WriteLine("File Created successfully");


        }
    }
}
