using System;

namespace Sirh3e.Steamer.Core.Auth
{
    public partial class SteamerAuthProvider : ISteamerAuthProvider
    {
        public static class Factory
        {
            public static SteamerAuthProvider CreateByApiKey(string apiKey)
                => new Builder().SetApiKey(apiKey ?? throw new ArgumentNullException(nameof(apiKey))).Build();
        }
    }
}