using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class TldExtendedAttribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("options")]
        public TldExtendedAttributeOption[] Options { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }
    }
}
