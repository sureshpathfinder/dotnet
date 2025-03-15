using System;
using System.Collections.Generic;
using System.Text;

namespace constructor
{
    class Constructor2
    {
        static int i;
        static Constructor2()
        { // a constructor for the entire class called 
            //once before the first object created
            i = 4;
            Console.Out.WriteLine("inside static construtor...");
        }
        public Constructor2()
        {
            Console.Out.WriteLine("inside regular construtor... i={0}", i);
        }
        ~Constructor2()
        { // destructor (hopefully) called for each object
            Console.Out.WriteLine("inside destructor");
        }

        static void Main(string[] args)
        {
            Console.Out.WriteLine("Constructor2");
            new Constructor2();
            new Constructor2();
        }
    }

}

