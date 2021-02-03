using System;
using System.Net.Http;

using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Parameters;

namespace Sirh3e.Steamer.Core.Method {
    public class SteamerMethod : ISteamerMethod {
        public const string SteamWebApiHostUrl = "https://api.steampowered.com";

        public SteamerMethod(ISteamerInterface @interface,
            HttpMethod httpMethod,
            string name, ulong version,
            ISteamerParameters parameters) {
            Interface = @interface ?? throw new ArgumentNullException(nameof(@interface));
            HttpMethod = httpMethod;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Version = version;
            Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        }

        public HttpMethod HttpMethod { get; }
        public ISteamerInterface Interface { get; }
        public string Name { get; }
        public ulong Version { get; }

        public string GetUriHost() {
            return $"{SteamWebApiHostUrl}/{Interface.Name}/{Name}/v{Version}";
        }

        public ISteamerParameters Parameters { get; }
    }
}