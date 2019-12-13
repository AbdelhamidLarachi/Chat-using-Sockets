using System;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    class clientSocket
    {
        static void Main(string[] args)
        {
            while (true)
            {
                TcpClient client = new TcpClient("172.20.10.2", 4523);
                NetworkStream ns = client.GetStream();
                byte[] buffer = new byte[100];
                string str = Console.ReadLine();
                BinaryWriter bw = new BinaryWriter(client.GetStream());
                bw.Write(str);

                BinaryReader br = new BinaryReader(client.GetStream());
                Console.WriteLine(br.ReadString());
            }
        }
    }
}