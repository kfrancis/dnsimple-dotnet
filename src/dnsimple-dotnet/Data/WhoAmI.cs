using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class WhoAmI
    {
        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}
