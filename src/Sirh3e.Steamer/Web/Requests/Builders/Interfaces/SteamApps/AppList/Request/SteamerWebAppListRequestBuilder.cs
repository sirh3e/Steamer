using System;
using Sirh3e.Steamer.Core.Builder;
using Sirh3e.Steamer.Core.Interface;

namespace Sirh3e.Steamer.Web.Requests.Builders.Interfaces.SteamApps.AppList.Request
{
    public class SteamerWebAppListRequestBuilder
        : SteamerRequestBuilder<SteamerWebAppListRequestBuilder, ISteamerWebAppListRequest>,
            ISteamerWebAppListRequestBuilder
    {
        public SteamerWebAppListRequestBuilder(ISteamerInterface @interface) : base(@interface) =>
            Request = new SteamerWebAppListRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

        public override ISteamerWebAppListRequest Build()
        {
            var request = Request;

            Request = new SteamerWebAppListRequest(Interface ??
                                                             throw new ArgumentNullException(nameof(Interface)));

            return request;
        }
    }
}