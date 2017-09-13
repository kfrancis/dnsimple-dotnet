using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace dnsimple_dotnet.Data
{
    public class CertificateBundle
    {
        [JsonProperty("private_key")]
        public string PrivateKey { get; set; }

        [JsonProperty("chain")]
        public string[] Chain { get; set; }

        [JsonProperty("root")]
        public object Root { get; set; }

        [JsonProperty("server")]
        public string Server { get; set; }
    }
}
