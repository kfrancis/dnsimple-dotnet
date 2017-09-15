using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class TemplateRecord
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("template_id")]
        public long TemplateId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("ttl")]
        public long Ttl { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
