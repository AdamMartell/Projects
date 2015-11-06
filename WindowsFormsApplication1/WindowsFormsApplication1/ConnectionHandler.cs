using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections.Concurrent;

namespace WindowsFormsApplication1
{
    class ConnectionHandler
    {
        public IPAddress ip;
        public TcpClient ClientSocket;
        public static NetworkStream OutgoingStream;
        public void OpenConnection()
        {
            ip = IPAddress.Parse("10.2.20.26");
            ClientSocket = new TcpClient("10.2.20.26", 8888);
            OutgoingStream = ClientSocket.GetStream();
        }
        public void Send(string info)
        {
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(info);
            OutgoingStream.Write(data, 0, data.Length);
        }
        public void Send(byte[] info)
        {
            OutgoingStream.Write(info, 0, info.Length);
        }
        public void Receive()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                int receivedDataLength = OutgoingStream.Read(data, 0, data.Length);
                Program.commands.Enqueue(data);
            }
        }
        public List<int> SingleReceive()
        {
            byte[] data = new byte[16388];
            List<int> heights = new List<int>(){};
            int receivedDataLength = OutgoingStream.Read(data, 0, data.Length);
            for (int x = 0; x < 16388; x += 4 )
            {
                heights.Add(BitConverter.ToInt32(data, x));
            }
            return heights;
        }
    }
}
