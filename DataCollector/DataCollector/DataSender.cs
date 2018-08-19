using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

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

            var myContent = JsonConvert.SerializeObject(dataItem);
            Console.WriteLine(myContent);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = client.PostAsync(uri, byteContent).Result;
            var responseString = response.Content.ReadAsStringAsync().Result;
        }
    }
}
