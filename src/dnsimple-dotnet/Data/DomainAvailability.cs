using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace dnsimple_dotnet.Data
{
    public class DomainAvailability
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("premium")]
        public bool Premium { get; set; }
    }
}
