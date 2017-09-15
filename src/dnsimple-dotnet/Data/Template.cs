using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class Template
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
