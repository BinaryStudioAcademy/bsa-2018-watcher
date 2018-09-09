using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

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
            if (response.StatusCode == HttpStatusCode.Created)
                return true;
            return false;
        }

        private void TestData(CollectedData date)
        {

            //var prc = date.Processes.Where(x => x.Name == "chrome").OrderByDescending(x => x.RamMBytes);


            float cpu = 0;
            float ram = 0;
            float pram = 0;
            foreach (var item in date.Processes)
            {
                System.Console.WriteLine($"cpu:{item.PCpu} " +
                    $"\t ram:{item.RamMBytes} " +
                    $"\t pram:{item.PRam} " +
                    $"\t ID:{item.prcID} " +
                    $"\t name:{item.Name}");

                cpu += item.PCpu;
                ram += item.RamMBytes;
                pram += item.PRam;
            }
            System.Console.WriteLine($"cpu:{cpu} \t ram:{ram} \t pram:{pram}");
            System.Console.WriteLine(date.Processes.Count);
        }
    }
}