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
            FileInfo f = new FileInfo("D:\\SSI_Suresh\\sample.txt");
            Console.WriteLine("f.FullName= "+f.FullName);
            Console.WriteLine("f.Name  : "+f.Name);
            
            if (f.Exists)
            {
                Console.WriteLine("f.CreationTime  :" +f.CreationTime);
                Console.WriteLine("f.Length :"+f.Length);
                Console.WriteLine("f.Attributes :"+f.Attributes);
                Console.WriteLine("f.DirectoryName:" + f.DirectoryName);
                Console.WriteLine(" f.Extension :" + f.Extension);
                
            }
            else
            {
                Console.WriteLine("File Not Found \n New File Will be created");
                f.Create();
            }
        }
    }
}
