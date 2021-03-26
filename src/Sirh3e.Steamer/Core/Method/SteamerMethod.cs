using System;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameters;

namespace Sirh3e.Steamer.Core.Method
{
    public class SteamerMethod : ISteamerMethod
    {
        public const string SteamWebApiHostUrl = "https://api.steampowered.com"; //ToDo

        public SteamerMethod(ISteamerInterface @interface,
            ISteamerHttpMethod httpMethod,
            string name,
            ulong version,
            ISteamerParameters parameters)
        {
            Interface = @interface ?? throw new ArgumentNullException(nameof(@interface));
            HttpMethod = httpMethod;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Version = version;
            Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        }

        public ISteamerHttpMethod HttpMethod { get; }
        public ISteamerInterface Interface { get; }
        public string Name { get; }
        public ulong Version { get; }

        public string GetUriHost() => $"{SteamWebApiHostUrl}/{Interface.Name}/{Name}/v{Version}";

        public ISteamerParameters Parameters { get; }
    }
}