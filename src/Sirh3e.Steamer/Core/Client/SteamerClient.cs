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

        public class Builder
        {
            public ISteamerAuthProvider AuthProvider { get; set; }

            public Builder SetAuthProvider(ISteamerAuthProvider authProvider)
            {
                AuthProvider = authProvider ?? throw new ArgumentNullException(nameof(authProvider));
                return this;
            }

            public SteamerClient Build()
            {
                return new(AuthProvider ?? throw new ArgumentNullException(nameof(AuthProvider)));
            }
        }
    }
}