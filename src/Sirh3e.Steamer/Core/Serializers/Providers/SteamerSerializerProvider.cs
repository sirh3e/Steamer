using System;
using System.Text.Json;
using Sirh3e.Steamer.Core.Serializers.Json;

namespace Sirh3e.Steamer.Core.Serializers.Providers
{
    public class SteamerSerializerProvider : ISteamerSerializerProvider
    {
        public SteamerSerializerProvider(ISteamerSerializer serializer)
        {
            Serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        }

        public ISteamerSerializer Serializer { get; }

        public class SteamerBuilder
        {
            protected ISteamerSerializer? Serializer { get; set; }

            public SteamerBuilder SetSerializer(ISteamerSerializer serializer)
            {
                Serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
                return this;
            }

            public SteamerSerializerProvider Build() =>
                new(Serializer ?? throw new ArgumentNullException(nameof(Serializer)));
        }

        public static class Factory
        {
            public static SteamerSerializerProvider CreateDefault()
                => new SteamerBuilder()
                    .SetSerializer(new SteamerSystemTextJsonSerializer(
                        new SteamerSystemTextJsonSerializerOptionsProvider(new JsonSerializerOptions())))
                    .Build();
        }
    }
}