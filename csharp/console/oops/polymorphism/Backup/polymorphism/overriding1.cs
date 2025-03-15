using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class Plane
    {

        public int TopSpeed()
        {
            return 30;
        }
    }
    class Jet : Plane
    {

        public new int TopSpeed()
        {
            
            return 9;
        }
    }
    class Airport
    {

        static void Main(string[] args)
        {
            Plane p = new Jet();
            Console.WriteLine("plane's top speed: {0}", p.TopSpeed());
            Jet j = new Jet();
            Console.WriteLine("jet's top speed: {0}", j.TopSpeed());
            Console.ReadLine();
        }
    }

}
