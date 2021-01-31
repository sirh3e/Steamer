using System;
using System.Net.Http;
using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.FriendList
{
    public class FriendListRequestBuilder : IFriendListRequestBuilder
    {
        public FriendListRequestBuilder(ISteamerInterface @interface)
        {
            Interface = @interface ?? throw new ArgumentNullException(nameof(@interface));
            Method = GetDefaultMethod();
        }

        public ISteamerInterface Interface { get; }
        public ISteamerMethod Method { get; protected set; }

        public ISteamerMethod GetDefaultMethod()
        {
            return new SteamerMethod(Interface,
                HttpMethod.Get, "GetFriendList", 1,
                new SteamerParameters(
                    new SteamerStringParameter("key"),
                    new SteamerStringParameter("steamid")));
        }

        public IFriendListRequest Build()
        {
            var request = new FriendListRequest
            {
                Method = Method
            };

            Method = GetDefaultMethod();
            return request;
        }

        public IFriendListRequestBuilder SetKey(string key)
        {
            _ = key ?? throw new ArgumentNullException(nameof(key));

            Method.Parameters.SetValue("key", key);

            return this;
        }

        public IFriendListRequestBuilder SetSteamId(ulong steamId)
        {
            Method.Parameters.SetValue("steamid", steamId.ToString());

            return this;
        }
    }
}