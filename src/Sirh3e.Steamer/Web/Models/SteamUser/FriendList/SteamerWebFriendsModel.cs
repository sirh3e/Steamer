﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sirh3e.Steamer.Web.Models.SteamUser.FriendList
{
    public class SteamerWebFriendsModel
    {
        [JsonPropertyName("friends")]
        public List<SteamerWebFriendModel> Friends { get; set; } = new();
    }
}