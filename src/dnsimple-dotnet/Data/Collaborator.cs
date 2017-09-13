using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace dnsimple_dotnet.Data
{
    public class Collaborator
    {
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("accepted_at")]
        public string AcceptedAt { get; set; }

        [JsonProperty("domain_id")]
        public long DomainId { get; set; }

        [JsonProperty("invitation")]
        public bool Invitation { get; set; }

        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }
    }
}
