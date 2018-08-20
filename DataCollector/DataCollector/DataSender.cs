using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataCollector
{
    public class DataSender
    {
        private HttpClient client;

        private string uri;

        public DataSender(HttpClient client, string dataAccumulatorUri)
        {
            this.client = client;
            this.uri = dataAccumulatorUri;
        }

        public async Task<bool> SendAsync(CollectedData dataItem)
        {
            var myContent = JsonConvert.SerializeObject(dataItem);

            var buffer = Encoding.UTF8.GetBytes(myContent);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(uri, byteContent);
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                return true;
            else return false;
        }
    }
}
