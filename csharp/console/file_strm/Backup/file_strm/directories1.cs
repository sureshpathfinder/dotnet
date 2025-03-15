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
            DirectoryInfo d = new DirectoryInfo("D:\\bsuresh\\program");
            Console.WriteLine("Folders=");
            foreach( Object i in d.GetDirectories())
                 Console.WriteLine(i);
            Console.WriteLine("Files=");
            Console.WriteLine(d.GetFiles());
            Console.WriteLine("Name="+d.Name);
            Console.WriteLine("Parent="+d.Parent);
            Console.WriteLine("Root="+d.Root);




        }
    }
}
