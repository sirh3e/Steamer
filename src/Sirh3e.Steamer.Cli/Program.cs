using System;
using System.Threading.Tasks;
using Sirh3e.Steamer.Web;

namespace Sirh3e.Steamer.Cli
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var apiKey = "D307045B67D6513FFACE19257331AF5A";
            var (client, service) = SteamerWebFactory.CreateByApiKey(apiKey);

            var request = client
                .SteamApps
                .AppList
                .Build();

            var response = service.Execute(request);

            response.Model.Match(model =>
            {
                model.AppList.Apps.ForEach(a => Console.WriteLine($"{a.AppId} {a.Name}"));
            }, () => { });
        }
    }
}