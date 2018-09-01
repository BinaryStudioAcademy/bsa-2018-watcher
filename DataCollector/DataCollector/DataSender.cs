using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataCollector
{
    public class DataSender
    {
        private readonly HttpClient _client;

        private readonly string _uri;

        public DataSender(HttpClient client, string dataAccumulatorUri)
        {
            _client = client;
            _uri = dataAccumulatorUri;
        }

        public async Task<bool> SendAsync(CollectedData dataItem)
        {
            var myContent = JsonConvert.SerializeObject(dataItem);

            var buffer = Encoding.UTF8.GetBytes(myContent);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync(_uri, byteContent);
            if (response.StatusCode == HttpStatusCode.Created)
                return true;
            return false;
        }
    }
}