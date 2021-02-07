﻿using Sirh3e.Steamer.Core.Builder;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser.FriendList.Request
{
    public interface ISteamerWebFriendListRequestBuilder : ISteamerRequestBuilder<ISteamerWebFriendListRequest>
    {
        public ISteamerWebFriendListRequestBuilder SetKey(string key);
        public ISteamerWebFriendListRequestBuilder SetSteamId(ulong steamId);
    }
}