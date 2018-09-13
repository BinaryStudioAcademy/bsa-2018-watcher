using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using DataAccumulator.DataAggregator.Interfaces;
using DataAccumulator.Shared.Models;

using Microsoft.Extensions.Options;

using Newtonsoft.Json;

namespace DataAccumulator.DataAggregator.Providers
{
    public class AzureMLProvider : IAzureMLProvider
    {
        private readonly HttpClient _client;
        public AzureMLProvider(IOptions<AzureMLOptions> options)
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", options.Value.ApiKey);
            _client.BaseAddress = new Uri(options.Value.Url);
        }

        public async Task<AzureMLResponse> CheckAnomaly(List<Dictionary<string, string>> input)
        {
            var request = new
            {
                Inputs = new Dictionary<string, List<Dictionary<string, string>>> { { "input1", input } },
                GlobalParameters = new Dictionary<string, string>()
                {
                    {
                        "postprocess.tailRows", "0"
                    },
                    {
                        "tspikedetector.sensitivity", "1"
                    },
                    {
                        "zspikedetector.sensitivity", "1"
                    },
                    {
                        "detectors.historywindow", "500"
                    },
                    {
                        "bileveldetector.sensitivity", "1"
                    },
                    {
                        "trenddetector.sensitivity", "1"
                    },
                    {
                        "detectors.spikesdips", "Both"
                    },
                }
            };

            var response = await _client.PostAsJsonAsync("", request);
            if (!response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                throw new InvalidOperationException(responseContent);
            }

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AzureMLResponse>(result);
        }
    }
}
