using dnsimple_dotnet.Endpoints;
using dnsimple_dotnet.Endpoints.Http;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet
{
    public class Client
    {
        private static string BaseUrl = "https://api.dnsimple.com/";

        public Accounts Accounts { get; private set; }
        public string AccessToken { get; set; }
        public string UserAgent { get; set; }

        public Client(RefitSettings settings = null) : this(new HttpEndpointAdapter(BaseUrl, settings))
        {
        }

        public Client(IEndpointAdapter adapter)
        {
            Accounts = adapter.Accounts;
        }
    }
}
