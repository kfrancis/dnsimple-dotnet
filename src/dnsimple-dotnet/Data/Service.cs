using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class Service
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("default_subdomain")]
        public object DefaultSubdomain { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("requires_setup")]
        public bool RequiresSetup { get; set; }

        [JsonProperty("setup_description")]
        public object SetupDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("settings")]
        public ServiceSetting[] Settings { get; set; }

        [JsonProperty("sid")]
        public string Sid { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }


}
