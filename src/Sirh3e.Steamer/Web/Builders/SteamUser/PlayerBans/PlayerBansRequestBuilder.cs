using System;
using System.Linq;
using System.Net.Http;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Parameter;
using Sirh3e.Steamer.Core.Parameters;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans
{
    public class PlayerBansRequestBuilder : IPlayerBansRequestBuilder //ToDo rename SteamerMethod
    {
        public PlayerBansRequestBuilder(ISteamerInterface @interface)
        {
            Method = new SteamerMethod(@interface,
                HttpMethod.Get, "GetPlayerBans", 1,
                new SteamerParameters(
                    new SteamerStringParameter("key"),
                    new SteamerStringParameter("steamids")));
        }

        public IPlayerBansRequestBuilder SetKey(string key)
        {
            _ = key ?? throw new ArgumentNullException(nameof(key));

            Method.Parameters.SetValue("key", key);

            return this;
        }

        public IPlayerBansRequestBuilder SetSteamIds(params ulong[] steamIds)
        {
            _ = steamIds ?? throw new ArgumentNullException(nameof(steamIds));

            var value = string.Join(",", steamIds.Select(steamId => steamId.ToString()).ToList());

            Method.Parameters.SetValue("steamids", value);

            return this;
        }

        public ISteamerMethod Method { get; }

        public IPlayerBansRequest Build()
        {
            return new PlayerBansRequest
            {
                Method = Method
            };
        }
    }
}