using Sirh3e.Steamer.Web.Services.SteamUserStats.Binders;

namespace Sirh3e.Steamer.Web.Services.SteamUserStats
{
    public interface ISteamerWebServiceSteamUserStatsBinders
        : ISteamerWebServicePlayerAchievementsBinder,
            ISteamerWebServiceSchemaForGameBinder,
            ISteamerWebServiceUserStatsForGameBinder
    {
    }
}