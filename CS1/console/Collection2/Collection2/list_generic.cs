using System;
using System.Collections.Generic;
using System.Text;

namespace Collection2
{
    class list_generic
    {
        public static void Main()
        {
            List<int> myInts = new List<int>();

            myInts.Add(1);
           // myInts.Add("Hello");
            myInts.Add(2);
            myInts.Add(3);

            for (int i = 0; i < myInts.Count; i++)
            {
                Console.WriteLine("MyInts: {0}", myInts[i]);
            }
        }

    }
}
