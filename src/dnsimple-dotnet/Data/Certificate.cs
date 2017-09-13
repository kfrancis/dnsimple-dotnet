using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace dnsimple_dotnet.Data
{
    /// <summary>
    /// Certificate
    /// </summary>
    /// <remarks>https://developer.dnsimple.com/v2/certificates/</remarks>
    public class Certificate
    {
        [JsonProperty("csr")]
        public string Csr { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("common_name")]
        public string CommonName { get; set; }

        [JsonProperty("authority_identifier")]
        public string AuthorityIdentifier { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("expires_on")]
        public string ExpiresOn { get; set; }

        [JsonProperty("domain_id")]
        public long DomainId { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("years")]
        public long Years { get; set; }
    }
}
