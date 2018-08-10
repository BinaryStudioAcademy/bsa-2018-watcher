using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DataCollector
{
    public class DataSender
    {
        TcpClient client;
        readonly string serverIp;
        public DataSender(string serverIp, int port)
        {
            this.serverIp = serverIp;
            client = new TcpClient(serverIp, port);
        }

        public void Send(CollectedData dataItem)
        {

            IFormatter formatter = new BinaryFormatter(); // the formatter that will serialize my object on my stream 

            NetworkStream stream = client.GetStream(); // the stream 
            formatter.Serialize(stream, dataItem); // the serialization process 

            stream.Close();
            client.Close();
        }
    }
}
