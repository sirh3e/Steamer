using System;
using Sirh3e.Steamer.Core.Auth;

namespace Sirh3e.Steamer.Core.Client
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