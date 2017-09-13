using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.ClientProtocol;
using NSubstitute;
using Xunit;
using System.Net.Http;
using dnsimple_dotnet.Endpoints;
using System.Collections.Generic;
using RichardSzalay.MockHttp;
using System.Text;
using System.Threading.Tasks;
using dnsimple_dotnet.Endpoints.Http;
using dnsimple_dotnet.Exceptions;
using System.IO;
using System.Text.RegularExpressions;

namespace dnsimple_dotnet.Tests
{
    public class CertificateTests : DnsimpleTestBase
    {
        [Fact]
        public async Task testListCertificatesSupportsPagination()
        {

        }

        [Fact]
        public async Task testListCertificatesSupportsExtraRequestOptions()
        {

        }

        [Fact]
        public async Task testListCertificatesSupportsSorting()
        {

        }

        [Fact]
        public async Task testListCertificatesProducesCertificateList()
        {

        }

        [Fact]
        public async Task testListCertificatesExposesPaginationInfo()
        {

        }

        [Fact]
        public async Task testGetCertificate()
        {

        }

        [Fact]
        public async Task testGetCertificateWhenNotFound()
        {
            Assert.Throws<ResourceNotFoundException>(() => { });
        }


    }
}
