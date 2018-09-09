using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

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
            TestData(dataItem);
            var myContent = JsonConvert.SerializeObject(dataItem);

            var buffer = Encoding.UTF8.GetBytes(myContent);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync(_uri, byteContent);
            return response.StatusCode == HttpStatusCode.Created;
        }

        private void TestData(CollectedData date)
        {
            float cpu = 0;
            float ram = 0;
            float pram = 0;
            foreach (var item in date.Processes)
            {
                cpu += item.PCpu;
                 ram += item.RamMBytes;
                 pram += item.PRam;
            }
            System.Console.WriteLine($"cpu:{cpu} \t ram:{ram} \t pram:{pram}");
        }
    }
}