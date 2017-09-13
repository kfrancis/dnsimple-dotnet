using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace dnsimple_dotnet.Data
{
public class Dnssec
{
    [JsonProperty("enabled")]
    public bool Enabled { get; set; }

    [JsonProperty("created_at")]
    public string CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public string UpdatedAt { get; set; }
}
}
