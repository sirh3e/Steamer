using Sirh3e.Steamer.Web.Services.PlayerService.Binders;

namespace Sirh3e.Steamer.Web.Services.PlayerService
{
    public interface ISteamerWebServicePlayerServiceServicesBinders
        : ISteamerWebServiceOwnedGamesGamesBinder,
            ISteamerWebServiceRecentlyPlayedGamesBinder
    {
    }
}