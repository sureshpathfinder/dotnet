using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using classlib;


namespace client3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CommonClass c = (CommonClass)Activator.GetObject(typeof(CommonClass), "tcp://localhost:8084/testRemoting");
            Console.WriteLine("Client is ready");
            c.FirstName = "Sure";
            c.LastName = "Info";
            Console.WriteLine("Return string: " + c.GetWelcomeString());
            Console.ReadLine();
        

        }
    }
}
