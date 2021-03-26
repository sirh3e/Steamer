using System;

namespace Sirh3e.Steamer.Core.Auth
{
    public partial class SteamerAuthProvider : ISteamerAuthProvider
    {
        public class Builder
        {
            public string? ApiKey { get; protected set; }

            public Builder SetApiKey(string apiKey)
            {
                ApiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
                return this;
            }

            public SteamerAuthProvider Build()
                => new(ApiKey ?? throw new ArgumentNullException(nameof(ApiKey)));

            public static implicit operator SteamerAuthProvider(Builder builder)
                => (_ = builder ?? throw new ArgumentNullException(nameof(builder))).Build();
        }
    }
}