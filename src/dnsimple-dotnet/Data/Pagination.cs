using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Data
{
    public class Pagination
    {
        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("current_page")]
        public long CurrentPage { get; set; }

        [JsonProperty("total_entries")]
        public long TotalEntries { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }
    }
}
