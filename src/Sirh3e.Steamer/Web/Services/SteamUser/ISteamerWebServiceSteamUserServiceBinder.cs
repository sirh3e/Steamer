﻿using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans;

namespace Sirh3e.Steamer.Web.Services.SteamUser
{
    public interface ISteamerWebServiceSteamUserServiceBinder :
        ISteamerServiceBinder<IPlayerBansRequest, IPlayerBansResponse>
    {
    }
}