using Sirh3e.Steamer.Core.Request;
using Sirh3e.Steamer.Core.Response;
using Sirh3e.Steamer.Utilities.Serializer;
using Sirh3e.Steamer.Web.Models.SteamUser;

namespace Sirh3e.Steamer.Web.Builders.SteamUser.PlayerBans
{
    public class PlayerBansResponse : IPlayerBansResponse
    {
        public ISteamerRequest Request { get; set; }

        public ISteamerSerializerDataProvider Provider { get; set; }
        public PlayerBansModel Model { get; set; }

        object ISteamerResponse.Model
        {
            get => Model;
            set => Model = (PlayerBansModel)value;
        }
    }
}