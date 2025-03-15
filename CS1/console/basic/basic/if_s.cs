using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class if_s
    {
        public static void Main(string[] arg)
        {
           // bool b = 12 > 4;
          float a=1.00001f;
          a = a + 0.00001f;
          if (a==1)
              Console.WriteLine("true");
          else
              Console.WriteLine("false");
            //Else if ladder
          Console.ReadKey();
          
        }
    }
}
