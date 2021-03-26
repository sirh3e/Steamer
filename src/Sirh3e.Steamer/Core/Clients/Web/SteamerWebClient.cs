using System;
using Sirh3e.Steamer.Core.Auth;
using Sirh3e.Steamer.Core.Serializers.Providers;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.EconService;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUser;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamUserStats;

namespace Sirh3e.Steamer.Core.Clients.Web
{
    public partial class SteamerWebClient : ISteamerWebClient
    {
        public SteamerWebClient(ISteamerAuthProvider authProvider, ISteamerSerializerProvider serializerProvider)
        {
            AuthProvider = authProvider ?? throw new ArgumentNullException(nameof(authProvider));
            SerializerProvider = serializerProvider ?? throw new ArgumentNullException(nameof(serializerProvider));

            //Builders
            EconService = new SteamerWebEconServiceInterfaceBuilder();
            PlayerService = new SteamerWebPlayerServiceInterfaceBuilder();
            SteamApps = new SteamerWebSteamAppsInterfaceBuilder();
            SteamUser = new SteamerWebUserInterfaceBuilder();
            SteamUserStats = new SteamerWebSteamUserStatsInterfaceBuilder();
        }

        public ISteamerAuthProvider AuthProvider { get; }
        public ISteamerSerializerProvider SerializerProvider { get; }
        public ISteamerWebEconServiceInterfaceBuilder EconService { get; }
        public ISteamerWebPlayerServiceInterfaceBuilder PlayerService { get; }
        public ISteamerWebSteamAppsInterfaceBuilder SteamApps { get; }
        public ISteamerWebUserInterfaceBuilder SteamUser { get; }
        public ISteamerWebSteamUserStatsInterfaceBuilder SteamUserStats { get; }
    }
}