using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;



namespace server3
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel tcpChannel = new TcpChannel(8084);
            ChannelServices.RegisterChannel(tcpChannel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(classlib.CommonClass), "testRemoting", WellKnownObjectMode.Singleton);
            Console.WriteLine("Server is ready");
            Console.ReadLine();
        }

    }
}
