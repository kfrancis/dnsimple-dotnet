using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Endpoints
{
    public interface IEndpointAdapter
    {
        Accounts Accounts { get; }
    }
}
