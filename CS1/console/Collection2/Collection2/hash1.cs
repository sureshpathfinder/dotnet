using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Collection2
{
    class hash1
    {
        public static void Main()
        {
            Hashtable h = new Hashtable();

            h.Add("week", "SunDay");
            h.Add(2, "MonDay");
            h.Add(5, "ThuDay");
            h.Add(3, "TueDay");
            h.Add("4", "WedDay");
            h.Add("112", "WedDay");
            h.Add("6", "FriDay");
            h.Add(32,"Saturday");
            h.Add("hh", 45);
            h.Add("fdgfd", 'a');
           h.Add(10, "Saturday");
            
            foreach (DictionaryEntry d in h)
            {
                Console.WriteLine(d.Key + "  -  "+ d.Value);
            }

            //Display a single Item 

            Console.WriteLine(" h[5]  =  "+h[5].ToString());
            //Search an Item 
            if (h.ContainsValue("TueDay"))
            {
                Console.WriteLine("Find");
            }
            else
            {
                Console.WriteLine("Not find");
            }
            //remove an Item 
            h.Remove(3);
            //Display all key value pairs
            //foreach (DictionaryEntry day in h)
            //{
            //    Console.WriteLine(day.Key + "   -   " + day.Value);
            //}

        }

    }
}
