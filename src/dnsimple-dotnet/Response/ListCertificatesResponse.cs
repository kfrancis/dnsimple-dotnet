using dnsimple_dotnet.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Response
{
    public class ListCertificatesResponse : PagedApiResponse<List<Certificate>>
    {
        public ListCertificatesResponse() : this(new List<Certificate>())
        {

        }

        public ListCertificatesResponse(List<Certificate> data)
        {
            Data = data;
        }
    }
}
