using Sirh3e.Steamer.Core.Method;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerSummaries.Request
{
    public class PlayerSummariesRequest : IPlayerSummariesRequest
    {
        public ISteamerMethod Method { get; set; }
    }
}