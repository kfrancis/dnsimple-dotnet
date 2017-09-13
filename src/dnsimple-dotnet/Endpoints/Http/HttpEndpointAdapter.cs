using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace dnsimple_dotnet.Endpoints.Http
{
    public class HttpEndpointAdapter : IEndpointAdapter
    {
        private string _baseUrl;
        private RefitSettings _settings;

        public HttpEndpointAdapter(string baseUrl, RefitSettings settings = null)
        {
            _baseUrl = baseUrl;
            _settings = settings;
        }

        public Accounts Accounts => new AccountsEndpoint(_baseUrl, _settings);
    }
}
