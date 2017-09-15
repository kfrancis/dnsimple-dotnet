using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class ZoneFile
    {
        [JsonProperty("zone")]
        public string Zone { get; set; }
    }
}
