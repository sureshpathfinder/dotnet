using System;
using System.Collections;
using System.Text;

namespace Collection2
{
    class sortedlist1
    {
        public static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add(7, "Data 5");
            s.Add(2, "Data 2");
            s.Add(6, "Data 6");
            s.Add(1, "Data 1");
            s.Add(4, "Data 4");
            s.Add(3, "Data 3");

            foreach (DictionaryEntry x in s)
            {
                Console.WriteLine(" Key : " + x.Key + " Value  : " + x.Value);
            }
        }
    }
}
