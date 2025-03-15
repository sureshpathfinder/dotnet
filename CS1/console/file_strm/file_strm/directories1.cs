using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace file_strm
{
    class directories1
    {
        public static void Main()
        {
            DirectoryInfo d = new DirectoryInfo("D:\\SSI_SURESH\\library\\");
            Console.WriteLine("\n Folders=");
            foreach( Object i in d.GetDirectories())
                 Console.WriteLine(i);

            Console.WriteLine("\n Files=");
            foreach (Object i in d.GetFiles())
                Console.WriteLine(i);
            
            Console.WriteLine("Name="+d.Name);
            Console.WriteLine("Parent="+d.Parent);
            Console.WriteLine("Root="+d.Root);
            Console.WriteLine("Root=" + d.FullName);




        }
    }
}
