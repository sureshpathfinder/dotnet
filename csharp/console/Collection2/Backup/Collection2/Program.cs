using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Collection2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            ArrayList a = new ArrayList();
            a.Add("Item4");
            a.Add("Item5");
            a.Add("Item2");
            a.Add("Item1");
            a.Add("Item3");
            Console.WriteLine ("Shows Added Items");
            for (i = 0; i <= a.Count - 1; i++)
            {
                Console.WriteLine(a[i].ToString());
            }
            //insert an item 
            a.Insert(3, "Item6");
            //sort itemms in an arraylist 
            a.Sort();
            //remove an item 
            a.Remove("Item1");
            //remove item from a specified index 
            a.RemoveAt(3);
            Console.WriteLine("Shows final Items the ArrayList");
            for (i = 0; i <= (a.Count - 1); i++)
            {
                Console.WriteLine(a[i].ToString());
            }
            Console.WriteLine("A Contains=" + a.Contains("Item5"));
        }
    }
}
