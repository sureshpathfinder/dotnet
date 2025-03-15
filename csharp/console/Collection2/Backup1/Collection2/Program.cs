using System;
using System.Collections;


namespace Collection2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            ArrayList a = new ArrayList();
            
            for(int n=1;n<=5;n++)
                a.Add("Item " +n);

            Console.WriteLine("a: " + a[0]);
            Console.WriteLine(" 1. Add \n 2.Remove \n 3.RemoveAt \n 4.Display \n 5.Sort \n 6.Contains \n 7.Clear \n 8.insert \n ");
          c:  Console.WriteLine("\n\n Enter the choice: ");
            i=int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Enter data :");
                    object o = Console.ReadLine();
                    a.Add(o);
                    break;
                case 2:
                    Console.WriteLine("Enter data to be removed :");
                    object m = Console.ReadLine();
                    a.Remove(m);
                    break;
                case 3:
                    Console.WriteLine("Enter position :");
                    int p = int.Parse(Console.ReadLine());
                    a.RemoveAt(p);
                    break;
                case 4:
                    Console.WriteLine("Collection a   no _ of  element:  "+ a.Count);
                    foreach (object x in a)
                        Console.Write(x.ToString()+ " , " );
                    break;
                case 5:

                    Console.WriteLine("\n Sorting order  :");
                    a.Sort();
                    foreach (object x in a)
                        Console.Write(x.ToString()+ " , " );
                    break;
                case 6:
                    object l=Console.ReadLine();
                    Console.WriteLine("A Contains = " + a.Contains(l));
                    break;
                case 7:
                    Console.WriteLine("Data removed");
                    a.Clear();
                    break;
                case 8:
                    Console.WriteLine("Enter position and value:");
                    int pos = int.Parse(Console.ReadLine());
                    object value = Console.ReadLine();
                    a.Insert(pos, value);
                    Console.WriteLine("Data inserted");
                    break;
                default:
                    System.Environment.Exit(0);
                    break;
            }
            goto c;

            
            

            
        }
    }
}
