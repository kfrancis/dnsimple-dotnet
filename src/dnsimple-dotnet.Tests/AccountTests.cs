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
using System.IO;
using System.Text.RegularExpressions;

namespace dnsimple_dotnet.Tests
{
    public class AccountTests : DnsimpleTestBase
    {
        [Fact]
        public async Task testListAccounts()
        {
            var client = MockAndExpectClient("https://api.dnsimple.com/v2/accounts", HttpMethod.Get, Resource("listAccounts/success-account.http"));

            var response = await client.Accounts.ListAccounts();

            var accounts = response.Data;
            Assert.Equal(1, accounts.Count);
            Assert.Equal(123, accounts[0].Id);
        }

        [Fact]
        public async Task testListAccountsForUser()
        {
            var client = MockAndExpectClient("https://api.dnsimple.com/v2/accounts", HttpMethod.Get, Resource("listAccounts/success-user.http"));

            var response = await client.Accounts.ListAccounts();

            var accounts = response.Data;
            Assert.Equal(2, accounts.Count);
            Assert.Equal(123, accounts[0].Id);
            Assert.Equal(456, accounts[1].Id);
        }
    }
}
