using System.Net;
using Refit;

namespace dnsimple_dotnet.Exceptions
{
    public sealed class ResourceNotFoundException : DnsimpleException
    {
        public ResourceNotFoundException(string message, string requestId, int statusCode, ApiException innerException)
            : base(message, requestId, statusCode, innerException)
        {
        }

        public ResourceNotFoundException(string message, string requestId, int statusCode)
            : base(message, requestId, statusCode)
        {
        }
    }
}