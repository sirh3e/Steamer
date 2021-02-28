using Sirh3e.Steamer.Web.Services.SteamUserStats.Binders;

namespace Sirh3e.Steamer.Web.Services.SteamUserStats
{
    public interface ISteamerWebServiceSteamUserStatsBinders
        : ISteamerWebServiceGlobalAchievementPercentagesForAppBinder,
            ISteamerWebServiceNumberOfCurrentPlayersBinder,
            ISteamerWebServicePlayerAchievementsBinder,
            ISteamerWebServiceSchemaForGameBinder,
            ISteamerWebServiceUserStatsForGameBinder
    {
    }
}