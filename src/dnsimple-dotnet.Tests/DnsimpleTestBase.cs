using Newtonsoft.Json;
using Refit;
using RichardSzalay.MockHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace dnsimple_dotnet.Tests
{
    public abstract class DnsimpleTestBase
    {
        public static string TEST_ACCESS_TOKEN = "test-access-token";

        public Client MockAndExpectClient(string expectedUrl, HttpMethod expectedMethod, string httpResponse)
        {
            return MockAndExpectClient(expectedUrl, expectedMethod, new Dictionary<string, string>(), new { }, httpResponse);
        }
        public Client MockAndExpectClient(string expectedUrl, HttpMethod expectedMethod, Dictionary<string, string> dictionary, object p, string httpResponse)
        {

            var mockHttp = new MockHttpMessageHandler();

            var settings = new Refit.RefitSettings()
            {
                HttpMessageHandlerFactory = () => mockHttp,
                JsonSerializerSettings = new Newtonsoft.Json.JsonSerializerSettings() { ContractResolver = new SnakeCasePropertyNamesContractResolver() }
            };

            mockHttp.Expect(expectedMethod, expectedUrl).Respond(req => new HttpResponseMessage() { Content = new StreamContent(new MemoryStream(Encoding.UTF8.GetBytes(httpResponse))), });


            var client = new Client(settings);
            client.AccessToken = TEST_ACCESS_TOKEN;

            return client;
        }
        public string Resource(string resourcePath)
        {
            // Giving up here. There's no nice way of processing the raw fixture data into a usable HttpResponseMessage
            // though a HttpResponseMessage.Parse(string nakedHttpMessage) would be nice. Cheat here, extract the json.
        
            var regEx = new Regex(@"\{(.|\s)*\}");
            return regEx.Match(RawResource(resourcePath)).Groups[0].Value;
        }

        public string RawResource(string resourcePath)
        {
            var assemblyPath = $"dnsimple-dotnet.Tests.Resources.{resourcePath.Replace("/", ".")}";
            var assembly = typeof(dnsimple_dotnet.Tests.DnsimpleTestBase).GetTypeInfo().Assembly;
            var resourceStream = assembly.GetManifestResourceStream(assemblyPath);
            string retVal = string.Empty;
            using (var reader = new StreamReader(resourceStream, Encoding.UTF8))
            {
                retVal = reader.ReadToEnd();
            }

            return retVal;
        }
    }
}
