using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Collection2
{
    class ienum1
    {
            static void Main(string[] ar)
            {
                ArrayList a = new ArrayList();
                a.Add("red");
                a.Add("blue");
                a.Add("green");
                a.Add("yellow");
                a.Add("aqua");
                a.Add("brown");
                a.Add("magenta");
                a.Add("purple");

                IEnumerator e = a.GetEnumerator();
                while (e.MoveNext())
                {
                    Object obj = e.Current;
                    Console.WriteLine(obj);
                }

                Console.WriteLine("\n\n From 2 : ");

                IEnumerator e2 = a.GetEnumerator(2, 4);
                while (e2.MoveNext())
                {
                    Object obj = e2.Current;
                    Console.WriteLine(obj);
                }

            }
        }
}
