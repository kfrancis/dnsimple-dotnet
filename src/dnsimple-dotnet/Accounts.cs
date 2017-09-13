using System;
using System.Collections.Generic;
using dnsimple_dotnet.Data;
using Refit;
using System.Threading.Tasks;
using dnsimple_dotnet.Response;

namespace dnsimple_dotnet
{
    public interface Accounts
    {
        [Get("/v2/accounts")]
        Task<ListAccountsResponse> ListAccounts();
    }
}
