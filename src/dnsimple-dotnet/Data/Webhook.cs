using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class Webhook
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
