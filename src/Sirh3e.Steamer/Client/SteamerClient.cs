using System;
using Sirh3e.Steamer.Auth;

namespace Sirh3e.Steamer.Client
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