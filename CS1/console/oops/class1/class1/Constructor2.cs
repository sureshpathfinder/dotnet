using System;
using System.Collections.Generic;
using System.Text;

namespace class1
{
    class Constructor2
    {
        static Constructor2()
        { 
            //once before the first object created
            Console.WriteLine("inside static construtor...");
        }

        //~Constructor2()
        //{ // destructor (hopefully) called for each object
        //    Console.WriteLine("inside destructor");
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Main method");
        }
    }

}

