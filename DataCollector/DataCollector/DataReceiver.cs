using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataCollector
{
    public class DataReceiver
    {
        TcpListener server;
        public DataReceiver(int port,IPAddress adress)
        {
            server = new TcpListener(adress, port);
            server.Start();
        }
        public void Receive()
        {
            TcpClient client = server.AcceptTcpClient();
            NetworkStream stream = client.GetStream();
            IFormatter formatter = new BinaryFormatter();
            CollectedData dataItem = (CollectedData)formatter.Deserialize(stream); // you have to cast the deserialized object 
            Console.WriteLine(dataItem.AvaliableRamBytes);
            stream.Close();
            client.Close();
            server.Stop();
        }
    }
}
