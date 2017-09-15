using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class Push
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("accepted_at")]
        public string AcceptedAt { get; set; }

        [JsonProperty("contact_id")]
        public long ContactId { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("domain_id")]
        public long DomainId { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
