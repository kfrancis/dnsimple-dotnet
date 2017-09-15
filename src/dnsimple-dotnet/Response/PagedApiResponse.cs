using dnsimple_dotnet.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Response
{
    public abstract class PagedApiResponse<T> : ApiResponse<T>
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }
}
