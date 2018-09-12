using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceBus.Shared.ML
{
    public class AzureMLOutput
    {
        public float Data { get; set; }
        [JsonProperty("TSpike")]
        public string TSpikeRaw { get; set; }
        [JsonProperty("ZSpike")]
        public string ZSpikeRaw { get; set; }
        [JsonIgnore]
        public bool TSpike { get => ToBool(TSpikeRaw);  }
        [JsonIgnore]
        public bool ZSpike { get => ToBool(ZSpikeRaw); }

        public DateTime Time { get; set; }

        private static bool ToBool(string str) => str == "1" ? true : false;

    }

    public class AzureMLResult
    {
        [JsonProperty("output1")]
        public List<AzureMLOutput> Output { get; set; }
    }

    public class AzureMLResponse
    {
        public AzureMLResult Results { get; set; }
    }
}


//Data: "34.8888"
//TSpike: "0"
//Time: "9/12/2018 6:41:45 AM"
//ZSpike: "0"
//rpalert: "0"
//rpscore: "-1.95412217588976"
//talert: "0"
//tscore: "-2.52422677148737"