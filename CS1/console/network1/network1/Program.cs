using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace network1
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener l = new TcpListener(8);
            l.Start();
            Console.WriteLine("Wait for client");
            Socket s = l.AcceptSocket();
            Console.WriteLine("Connected");
            string d = "hello";
            byte[] b = System.Text.Encoding.ASCII.GetBytes(d.ToCharArray());
            int len = s.Send(b, b.Length, 0);
            l.Stop();

        }
    }
}
