﻿using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.FriendList.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerBans.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.PlayerSummaries.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.ResolveVanityUrl.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser.UserGroupList.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser
{
    public class SteamerWebSteamUserInterfaceBuilder : SteamerInterface, ISteamerWebSteamUserInterfaceBuilder
    {
        public SteamerWebSteamUserInterfaceBuilder() : base("ISteamUser") //ToDo rename
        {
            FriendList = new SteamerWebFriendListRequestBuilder(this);
            PlayerBans = new SteamerWebPlayerBansRequestBuilder(this);
            PlayerSummaries = new SteamerWebPlayerSummariesRequestBuilder(this);
            ResolveVanityUrl = new SteamerWebResolveVanityUrlRequestBuilder(this);
            UserGroupList = new SteamerWebUserGroupListRequestBuilder(this);
        }

        public ISteamerWebFriendListRequestBuilder FriendList { get; }
        public ISteamerWebPlayerBansRequestBuilder PlayerBans { get; }
        public ISteamerWebPlayerSummariesRequestBuilder PlayerSummaries { get; }
        public ISteamerWebResolveVanityUrlRequestBuilder ResolveVanityUrl { get; }
        public ISteamerWebUserGroupListRequestBuilder UserGroupList { get; }
    }
}