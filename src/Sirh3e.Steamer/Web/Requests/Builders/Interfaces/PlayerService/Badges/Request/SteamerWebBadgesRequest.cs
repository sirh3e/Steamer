﻿using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.Badges.Request
{
    public class SteamerWebBadgesRequest : SteamerRequest, ISteamerWebBadgesRequest
    {
        public SteamerWebBadgesRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
            new SteamerHttpMethodGet(),
            "GetBadges", 1,
            new
                SteamerParameters(new SteamerStringParameter("key"),
                    new
                        SteamerU64Parameter("steamid"))))
        {
        }
    }
}