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
            var accounts = await client.Accounts.ListAccounts();

            accounts.Data.ForEach(x => { Console.WriteLine($"Id: {x.Id}: Plan: {x.PlanIdentifier}, Email: {x.Email}, CreatedAt: {DateTime.Parse(x.CreatedAt).ToLocalTime()}"); });
        }
    }
}
