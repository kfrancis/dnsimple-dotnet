using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet.Exceptions
{
    public class DnsimpleException : Exception
    {
        private string message;

        public string RequestId { get; private set; }
        public int StatusCode { get; private set; }

        public DnsimpleException(string message, string requestId, int statusCode, Exception e)
            : base(message, e)
        {
            RequestId = requestId;
            StatusCode = statusCode;
        }

        public DnsimpleException(string message, string requestId, int statusCode)
            :this(message, requestId, statusCode, null)
        {
        }

        public static DnsimpleException TransformException(ApiException e)
        {
            switch(e.StatusCode)
            {
                case System.Net.HttpStatusCode.NotFound:
                    return new ResourceNotFoundException($"Failed to retrieve domain: {e.Message}", null, (int)e.StatusCode, e);
                default:
                    return new DnsimpleException(e.Message, null, (int)e.StatusCode, e);
            }
        }
    }
}
