using dnsimple_dotnet;
using System;
using System.Threading.Tasks;

namespace ConsumerApp.NetCore
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Client client = new Client();
            client.AccessToken = "YOUR-ACCESS-TOKEN";
            client.UserAgent = "your-user-agent";

            //WhoAmIResponse response = client.Identity.WhoAmI();

            var accounts = await client.Accounts.ListAccounts();

            accounts.Data.ForEach(x => { Console.WriteLine($"Id: {x.Id}: Plan: {x.PlanIdentifier}, Email: {x.Email}, CreatedAt: {DateTime.Parse(x.CreatedAt).ToLocalTime()}"); });
        }
    }
}
