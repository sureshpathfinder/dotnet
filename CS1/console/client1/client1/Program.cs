using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace client1
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient c = new TcpClient("localhost", 8);
            NetworkStream ms = c.GetStream();
            int v;
            while (true)
            {
                v = ms.ReadByte();
                if (v == -1)
                    break;
                Console.WriteLine((char)v);
            }
        }
    }
}
