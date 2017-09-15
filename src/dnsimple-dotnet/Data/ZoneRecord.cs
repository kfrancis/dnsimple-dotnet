using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class ZoneRecord
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("system_record")]
        public bool SystemRecord { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("priority")]
        public object Priority { get; set; }

        [JsonProperty("parent_id")]
        public object ParentId { get; set; }

        [JsonProperty("regions")]
        public string[] Regions { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("ttl")]
        public long Ttl { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("zone_id")]
        public string ZoneId { get; set; }
    }

}
