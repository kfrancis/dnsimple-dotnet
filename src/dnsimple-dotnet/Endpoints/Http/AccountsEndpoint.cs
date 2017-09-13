using System;
using System.Collections.Generic;
using System.Text;
using dnsimple_dotnet.Data;
using Refit;
using System.Net.Http;
using System.Threading.Tasks;
using dnsimple_dotnet.Response;

namespace dnsimple_dotnet.Endpoints.Http
{
    public class AccountsEndpoint : Accounts
    {
        private string _baseUrl;
        private RefitSettings _settings;

        public AccountsEndpoint(string baseUrl, RefitSettings settings)
        {
            _baseUrl = baseUrl;
            _settings = settings;
        }

        public Task<ListAccountsResponse> ListAccounts()
        {
            var client = RestService.For<Accounts>(_baseUrl, _settings);
            return client.ListAccounts();
        }
    }
}
