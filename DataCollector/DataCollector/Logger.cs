using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataCollector
{
    internal class Logger
    {
        private readonly HttpClient _client;
        private readonly Guid _clientId;
        private readonly string _uri;

        public Logger(HttpClient client, Guid clientId,string uri)
        {
            _client = client;
            _clientId = clientId;
            _uri = uri;
        }

        public async Task Log(string message, LogLevel logLevel = LogLevel.Info)
        {
            var actionLog = new ActionLog(message, DateTime.Now, logLevel);

            actionLog.ClientId = _clientId;

            var content = JsonConvert.SerializeObject(actionLog);
            var buffer = Encoding.UTF8.GetBytes(content);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            await _client.PostAsync(_uri, byteContent);
        }
    }
}
