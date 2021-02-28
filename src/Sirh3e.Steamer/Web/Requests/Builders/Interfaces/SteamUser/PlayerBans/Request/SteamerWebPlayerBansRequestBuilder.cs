using System;
using System.Linq;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request
{
    public class SteamerWebPlayerBansRequestBuilder :
        SteamerRequestBuilder<SteamerWebPlayerBansRequestBuilder, ISteamerWebPlayerBansRequest>,
        ISteamerWebPlayerBansRequestBuilder //ToDo rename SteamerMethod
    {
        public SteamerWebPlayerBansRequestBuilder(ISteamerInterface @interface) : base(@interface)
            => Request = new SteamerWebPlayerBansRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebPlayerBansRequest Build()
        {
            var request = Request;

            Request = new SteamerWebPlayerBansRequest(Interface ?? throw new ArgumentNullException(nameof(Interface)));

            return request;
        }

        public ISteamerWebPlayerBansRequestBuilder SetKey(string key)
            => SetValue("key", key ?? throw new ArgumentNullException(nameof(key)));

        //ToDo change parameter to / create a parameter for list
        public ISteamerWebPlayerBansRequestBuilder SetSteamIds(params ulong[] steamIds) =>
            SetValue("steamids",
                     string.Join(",",
                                 steamIds.Select(steamId => steamId.ToString()).ToList() ??
                                 throw new ArgumentNullException(nameof(steamIds))));
    }
}