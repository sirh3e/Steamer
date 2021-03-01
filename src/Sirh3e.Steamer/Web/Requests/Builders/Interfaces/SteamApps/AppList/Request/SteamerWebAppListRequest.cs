using Sirh3e.Steamer.Core.Interface;
using Sirh3e.Steamer.Core.Method;
using Sirh3e.Steamer.Core.Net.Http.Methods;
using Sirh3e.Steamer.Core.Parameter.Types;
using Sirh3e.Steamer.Core.Parameters;
using Sirh3e.Steamer.Core.Request;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request
{
    public class SteamerWebAppListRequest : SteamerRequest, ISteamerWebAppListRequest
    {
        public SteamerWebAppListRequest(ISteamerInterface @interface) : base(new SteamerMethod(@interface,
                                                                                           new SteamerHttpMethodGet(),
                                                                                           "GetAppList", 2,
                                                                                           new SteamerParameters()))
        {
        }
    }
}