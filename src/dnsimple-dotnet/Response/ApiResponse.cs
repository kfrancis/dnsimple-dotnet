using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Response
{
    public abstract class ApiResponse<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
