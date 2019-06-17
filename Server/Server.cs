using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;

namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TCP SERVERI"); Console.WriteLine("===================================\n");

            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 9999); Socket socketMireseardhes = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socketMireseardhes.Bind(ip); socketMireseardhes.Listen(10); Console.WriteLine("Waiting for connection..."); Socket serverSocket = socketMireseardhes.Accept(); IPEndPoint clientep = (IPEndPoint)serverSocket.RemoteEndPoint; Console.WriteLine("Serveri u lidh me hostin: {0} ne portin {1}", clientep.Address, clientep.Port);

            byte[] edhenaP = new byte[1024]; int gjatesia = serverSocket.Receive(edhenaP); string eardhura = Encoding.ASCII.GetString(edhenaP, 0, gjatesia); Console.WriteLine(eardhura); string welcome = eardhura.ToUpper(); byte[] edhenaD = new byte[1024]; edhenaD = Encoding.ASCII.GetBytes(welcome); serverSocket.Send(edhenaD, edhenaD.Length, SocketFlags.None);


Console.WriteLine("Lidhja u shkeput nga {0}", clientep.Address); serverSocket.Close(); socketMireseardhes.Close();

            Console.WriteLine("\n\nShtypeni tastin 'Enter' per te perfunduar punen"); Console.ReadLine();
        }
    }
}