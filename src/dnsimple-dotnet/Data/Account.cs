using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace dnsimple_dotnet.Data
{
    /// <summary>
    /// Account
    /// </summary>
    /// <remarks>https://developer.dnsimple.com/v2/accounts/</remarks>
    public class Account
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("plan_identifier")]
        public string PlanIdentifier { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
