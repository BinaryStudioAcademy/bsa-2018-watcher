using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DataCollector
{
    public class DataSender
    {
        HttpClient client;
        public DataSender()
        {
            client = new HttpClient();
        }

        public void Send(CollectedData dataItem, string uri)
        {

            IFormatter formatter = new BinaryFormatter(); // the formatter that will serialize my object on my stream 

            client.PostAsync(uri, new StringContent(JsonConvert.SerializeObject(dataItem)));

        }
    }
}
