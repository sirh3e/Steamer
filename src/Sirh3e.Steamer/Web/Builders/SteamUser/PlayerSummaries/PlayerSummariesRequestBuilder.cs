using System;
using System.Linq;
using System.Net.Http;

using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries {
    public class PlayerSummariesRequestBuilder : IPlayerSummariesRequestBuilder {
        public PlayerSummariesRequestBuilder(ISteamerInterface @interface) {
            Interface = @interface ?? throw new ArgumentNullException(nameof(@interface));
            Method = GetDefaultMethod();
        }

        public ISteamerInterface Interface { get; }
        public ISteamerMethod Method { get; protected set; }

        public ISteamerMethod GetDefaultMethod() {
            return new SteamerMethod(Interface,
                HttpMethod.Get, "GetPlayerSummaries", 2,
                new SteamerParameters(
                    new SteamerStringParameter("key"),
                    new SteamerStringParameter("steamids")));
        }

        public IPlayerSummariesRequestBuilder SetKey(string key) {
            _ = key ?? throw new ArgumentNullException(nameof(key));

            Method.Parameters.SetValue("key", key);

            return this;
        }

        public IPlayerSummariesRequestBuilder SetSteamIds(params ulong[] steamIds) {
            _ = steamIds ?? throw new ArgumentNullException(nameof(steamIds));

            var value = string.Join(",", steamIds.Select(steamId => steamId.ToString()).ToList());

            Method.Parameters.SetValue("steamids", value);

            return this;
        }

        public IPlayerSummariesRequest Build() {
            var request = new PlayerSummariesRequest {
                Method = Method
            };

            Method = GetDefaultMethod();
            return request;
        }
    }
}