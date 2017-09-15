using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class WhoIsPrivacy
    {
        [JsonProperty("domain_id")]
        public long DomainId { get; set; }

        [JsonProperty("expires_on")]
        public string ExpiresOn { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
