using System.Net.Http;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Parameter;
using Sirh3e.Steamer.Core.Parameters;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans
{
    public class PlayerBansRequestBuilder : SteamerMethod, IPlayerBansRequestBuilder
    {
        public PlayerBansRequestBuilder(ISteamerInterface @interface) :
            base(@interface, HttpMethod.Get, "GetPlayerBans", 1,
            new SteamerParameters(new SteamerStringParameter("steamids", "")))
        {
        }

        public IPlayerBansRequestBuilder SetSteamIds(params ulong[] steamids)
        {
            return this;
        }

        public IPlayerBansRequest Build()
        {
            return new PlayerBansRequest
            {
                Method = this
            };
        }
    }
}