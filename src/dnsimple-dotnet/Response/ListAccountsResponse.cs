using dnsimple_dotnet.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Response
{
    public class ListAccountsResponse : ApiResponse<List<Account>>
    {
        public ListAccountsResponse() : this(new List<Account>())
        {

        }

        public ListAccountsResponse(List<Account> data)
        {
            Data = data;
        }
    }
}
