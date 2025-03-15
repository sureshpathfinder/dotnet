using System;
using System.Collections.Generic;
using System.Text;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a ={ 2, 21, 3, 2,15};

            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i]+" ");
            
            Console.WriteLine("\n  Array.BinarySearch(a,44)=" + Array.BinarySearch(a,15));
            Console.WriteLine("\n  Array.IndexOf(a,2) =" + Array.IndexOf(a,2));
            Console.WriteLine("\n  Array.LastIndexOf(2)=" + Array.LastIndexOf(a,2));
            Array.Sort(a);

            Console.WriteLine("\n Ascending Order");
            foreach (int i in a)
                Console.WriteLine("  " + i);

            Console.WriteLine("\n decending Order");
            Array.Reverse(a);
            foreach (int i in a)
                Console.WriteLine("  " + i);
            
            int[] b = { 2, 3, 5 ,0,0,0,0};
            a.CopyTo(b, 2);
            Console.WriteLine("\n a.CopyTo(b)  b=");
            foreach (int i in b)
                Console.Write("  " + i);

            Array.Copy(a,b,3);
            Console.WriteLine("\n Array.Copy(a, b)  b=");
            foreach (int i in b)
                Console.Write("  " + i);
                        
            Array.Clear(a, 0, 5);
            Console.WriteLine("\n Clear="  );
            foreach (int i in a)
                Console.Write("  " + i);

            Console.ReadKey();
            }
        }
}

