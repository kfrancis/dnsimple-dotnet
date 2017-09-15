using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class NameServer
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("ipv6")]
        public string Ipv6 { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("ipv4")]
        public string Ipv4 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
