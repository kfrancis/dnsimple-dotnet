using dnsimple_dotnet.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Response
{
    public class GetCertificateResponse : ApiResponse<Certificate>
    {
        public GetCertificateResponse(): this(new Certificate())
        {

        }

        public GetCertificateResponse(Certificate data)
        {
            Data = data;
        }
    }
}
