﻿using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request
{
    public class SteamerWebPlayerBansRequest : SteamerRequest, ISteamerWebPlayerBansRequest
    {
        public SteamerWebPlayerBansRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
            new SteamerHttpMethodGet(), "GetPlayerBans",
            1,
            new
                SteamerParameters(new SteamerStringParameter("key"),
                    new
                        SteamerStringParameter("steamids"))))
        {
        }
    }
}