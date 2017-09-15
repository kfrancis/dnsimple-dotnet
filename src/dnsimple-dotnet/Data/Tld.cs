using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class Tld
    {
        [JsonProperty("registration_enabled")]
        public bool RegistrationEnabled { get; set; }

        [JsonProperty("idn")]
        public bool Idn { get; set; }

        [JsonProperty("auto_renew_only")]
        public bool AutoRenewOnly { get; set; }

        [JsonProperty("minimum_registration")]
        public long MinimumRegistration { get; set; }

        [JsonProperty("tld")]
        public string OtherTld { get; set; }

        [JsonProperty("transfer_enabled")]
        public bool TransferEnabled { get; set; }

        [JsonProperty("renewal_enabled")]
        public bool RenewalEnabled { get; set; }

        [JsonProperty("tld_type")]
        public long TldType { get; set; }

        [JsonProperty("whois_privacy")]
        public bool WhoisPrivacy { get; set; }
    }
}
