using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class SampleInheritance
    {
        public static void Main(string[] arg)
        {
            Bike b = new Bike(12, 43000, "Blue");
            b.Print();
            Car c = new Car(12, 1300000, "Gray");
            c.Print();
            Console.ReadKey();
        }
    }

    

    class Bike : vehicle
    {
        string color = "red";
        internal Bike(int id, double p, string c): base (id, p, c)
        {
            Console.WriteLine(vid);
            Console.WriteLine(price);
            Console.WriteLine(color);
            Console.WriteLine(base.color);
        }
    }

    class Car : vehicle
    {
       public Car(int p1, int p2, string p3) : base (p1, p2, p3)
        {
           
        }

    }
}
