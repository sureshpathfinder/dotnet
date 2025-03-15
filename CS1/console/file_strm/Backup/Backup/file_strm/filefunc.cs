using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace file_strm
{
    class filefunc
    {

        public static void Main()
        {
            FileInfo f = new FileInfo("D:/bsuresh/NEWFILE2.txt");
            Console.WriteLine(f.FullName);
            Console.WriteLine(f.Name);
            
            if (f.Exists)
            {
                Console.WriteLine(f.CreationTime);
                Console.WriteLine(f.Length);
                Console.WriteLine(f.Attributes);
                
            }
            else
            {
                Console.WriteLine("File Not Found \n New File Will be created");
                f.Create();
            }
        }
    }
}
