﻿using Sirh3e.Steamer.SteamerWebService.Builders.Interfaces.SteamUser;

namespace Sirh3e.Steamer.SteamerWebService.Builders.Interfaces
{
    public interface ISteamerWebInterfaceBuilder
    {
        public ISteamerWebUserInterfaceBuilder SteamerWebUser { get; }
    }
}