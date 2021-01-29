using System;
using Sirh3e.Steamer.Core.Auth;

namespace Sirh3e.Steamer.Core.Clients
{
    public class SteamerClient : ISteamerClient
    {
        public SteamerClient(ISteamerAuthProvider authProvider)
        {
            AuthProvider = authProvider ?? throw new ArgumentNullException(nameof(authProvider));
        }

        public ISteamerAuthProvider AuthProvider { get; }


    }
}