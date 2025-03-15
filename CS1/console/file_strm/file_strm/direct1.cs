using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace file_strm
{
    class direct1
    {
        public static void Main(string[] arg)
        {
           // Directory.CreateDirectory("d:\\testfolder");

            //Directory.Delete("d:\\testfolder");

           Console.WriteLine("Timing : "+  Directory.GetCreationTime("d:\\joomla"));

          // Directory.Move("d:\\testfolder","d:\\hcjs");

            Console.WriteLine("Directory Created");
        }
    }
}
