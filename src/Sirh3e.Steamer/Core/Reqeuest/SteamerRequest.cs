using System;
using Sirh3e.Steamer.Core.Clients;
using Sirh3e.Steamer.Core.Method;

namespace Sirh3e.Steamer.Core.Reqeuest
{
    public class SteamerRequest : ISteamerRequest
    {
        public SteamerRequest(ISteamerClient client, ISteamerMethod method)
        {
            Client = client ?? throw new ArgumentNullException(nameof(client));
            Method = method ?? throw new ArgumentNullException(nameof(method));
        }

        public ISteamerClient Client { get; }
        public ISteamerMethod Method { get; }
    }
}