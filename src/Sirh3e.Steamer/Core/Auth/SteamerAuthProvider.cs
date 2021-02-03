using System;

namespace Sirh3e.Steamer.Core.Auth {
    public class SteamerAuthProvider : ISteamerAuthProvider {
        public SteamerAuthProvider(string apiKey) {
            ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }

        public string ApiKey { get; }
    }
}