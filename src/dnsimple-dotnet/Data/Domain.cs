using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace dnsimple_dotnet.Data
{
    /// <summary>
    /// Domain
    /// </summary>
    /// <remarks>https://developer.dnsimple.com/v2/domains/</remarks>
    public class Domain
    {
        [JsonProperty("expires_on")]
        public object ExpiresOn { get; set; }

        [JsonProperty("registrant_id")]
        public object RegistrantId { get; set; }

        [JsonProperty("auto_renew")]
        public bool AutoRenew { get; set; }

        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("private_whois")]
        public bool PrivateWhois { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("unicode_name")]
        public string UnicodeName { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
