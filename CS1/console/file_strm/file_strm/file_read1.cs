using System;
using System.IO;
using System.Collections.Generic;
using System.Text;


namespace file_strm
{
    class file_read1
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("D:\\SSI_Suresh\\sample.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader s = new StreamReader(fileStream);
            string line;
            Console.WriteLine("File content: ");
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();
            fileStream.Close();

        }

    }
}
