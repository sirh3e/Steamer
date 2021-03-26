using System;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Request;
using Sirh3e.Steamer.Web.Requests.Builders.Interfaces.PlayerService.CommunityBadgeProgress.Response;
using Sirh3e.Steamer.Web.Services;

namespace Sirh3e.Steamer.Web.Extensions.Interfaces.PlayerService.Request
{
    public static class SteamerWebCommunityBadgeProgressRequestExtension
    {
        public static ISteamerWebCommunityBadgeProgressResponse ServiceExecute(
            this ISteamerWebCommunityBadgeProgressRequest request,
            ISteamerWebService service)
        {
            _ = request ?? throw new ArgumentNullException(nameof(request));
            _ = service ?? throw new ArgumentNullException(nameof(service));

            return service.Execute(request);
        }
    }
}