﻿using Sirh3e.Steamer.Core.Service;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.SteamerWebService.Requests.Builders.Interfaces.SteamUser.PlayerBans.Response;

namespace Sirh3e.Steamer.SteamerWebService.Services.SteamUser
{
    public interface ISteamerWebServicePlayerBansBinder : ISteamerServiceBinder<ISteamerWebPlayerBansRequest, ISteamerWebPlayerBansResponse>
    {
    }
}