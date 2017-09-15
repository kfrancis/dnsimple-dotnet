using dnsimple_dotnet.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace dnsimple_dotnet
{
    /// <summary>
    /// Certificates
    /// </summary>
    /// <remarks>https://developer.dnsimple.com/v2/domains/certificates</remarks>
    public interface Certificates
    {
        /// <summary>
        /// Lists the domains in the account.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="domainId">The domain name or ID</param>
        /// <returns>The list certificates response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/domains/certificates/#list</remarks>
        ListCertificatesResponse ListCertificates(string accountId, string domainId);

        /// <summary>
        /// Lists the certificates in the domain.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="domainId">The domain name or ID</param>
        /// <param name="options">Options to pass to the certificates API</param>
        /// <returns>The list certificates response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/domains/certificates/#list</remarks>
        ListCertificatesResponse ListCertificates(string accountId, string domainId, Dictionary<string, string> options);

        /// <summary>
        /// Get a specific certificate associated to a domain using the certificate's ID.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="domainId">The domain name or ID</param>
        /// <param name="certificateId">The certificate ID</param>
        /// <returns>The get certificate repsonse</returns>
        /// <remarks>https://developer.dnsimple.com/v2/domains/certificates/#get</remarks>
        GetCertificateResponse GetCertificate(string accountId, string domainId, string certificateId);

        /// <summary>
        /// Downloads certificate associated with a domain.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="domainId">The domain name or ID</param>
        /// <param name="certificateId">The certificate ID</param>
        /// <returns>The download certificate response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/domains/certificates/#download</remarks>
        DownloadCertificateResponse DownloadCertificate(string accountId, string domainId, string certificateId);

        /// <summary>
        /// Get the certificate private key associated with a domain.
        /// </summary>
        /// <param name="accountId">The account ID</param>
        /// <param name="domainId">The domain name or ID</param>
        /// <param name="certificateId">The certificate ID</param>
        /// <returns>The get certificate private key response</returns>
        /// <remarks>https://developer.dnsimple.com/v2/domains/certificates/#private-key</remarks>
        GetCertificatePrivateKeyResponse GetCertificatePrivateKey(string accountId, string domainId, string certificateId);
    }
}
