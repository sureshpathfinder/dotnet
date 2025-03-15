using System;
using System.Collections.Generic;
using System.Text;

namespace enum1
{
    // declares the enum
    public enum Volume
    {
        Low,
        Medium,
        High
    }
    class Program
    {
        static void Main(string[] args)
        { 
            // create and initialize 
            // instance of enum type
            Volume myVolume = Volume.Medium;
            Console.WriteLine(myVolume);
            // on enum value    
            switch (myVolume)   
            {
                case Volume.Low:
                    Console.WriteLine("The volume has been turned Down.");
                    break;
                case Volume.Medium:
                    Console.WriteLine("The volume is in the middle.");
                    break;
                case Volume.High:
                    Console.WriteLine("The volume has been turned up.");
                    break;
            }
            Console.ReadLine();
        }
}         
}

