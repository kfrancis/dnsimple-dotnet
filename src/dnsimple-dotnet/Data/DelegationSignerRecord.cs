using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace dnsimple_dotnet.Data
{
    public class DelegationSignerRecord
    {
        [JsonProperty("digest_type")]
        public string DigestType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("algorithm")]
        public string Algorithm { get; set; }

        [JsonProperty("digest")]
        public string Digest { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("domain_id")]
        public long DomainId { get; set; }

        [JsonProperty("keytag")]
        public string Keytag { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
