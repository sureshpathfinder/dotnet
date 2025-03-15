using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection2
{
    class Class2
    {
        public static void Main(string[] arg)
        {
            ArrayList a = new ArrayList();
            a.Add(34);
            a.Add(34);
            a.Add(24);
            a.Add(78);
            a.Add(24);
            a.Add(78);
            a.Add(98);
            //a.Add("item1");
            //a.Add(34.4454);
            //a.Add('@');
            Console.WriteLine("\n Before Sorted");
            Disp(a);
            a.Sort();
            Console.WriteLine("\n \n After Sorted");
            Disp(a);

            Console.WriteLine("\n Removing element: ");
            a.RemoveAt (0);

            Disp(a);

            Console.WriteLine(a.Contains(78));

            Console.WriteLine(a.IndexOf(34));
            Console.WriteLine(a.BinarySearch(34));
            Disp_Iterator(a);
            Disp(a);

            Console.ReadKey();
        }

        static void Disp(ArrayList a)
        {
            Console.WriteLine("\n\n Collection value: ");
            foreach (var x in a)
            {
                Console.Write(x + ",");
               // a.RemoveAt(1);
            }
        }

        static void Disp_Iterator(ArrayList a)
        {
            Console.WriteLine("\n\n Collection value: ");
            ArrayList m = (ArrayList)a.Clone();
            IEnumerator i = m.GetEnumerator(2,2);

            while (i.MoveNext())
            {
                Console.Write(i.Current + ",");
                if (a.IndexOf(i.Current) == a.LastIndexOf(i.Current))
                    a.Remove(i.Current);
            }
        }
    }
}
