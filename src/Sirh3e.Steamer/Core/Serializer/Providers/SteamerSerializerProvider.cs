using System;

namespace Sirh3e.Steamer.Core.Serializer.Providers
{
    public class SteamerSerializerProvider : ISteamerSerializerProvider
    {
        public SteamerSerializerProvider(ISteamerSerializer serializer)
        {
            Serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
        }

        public ISteamerSerializer Serializer { get; }

        public class Builder
        {
            protected ISteamerSerializer Serializer { get; set; }

            public Builder SetSerializer(ISteamerSerializer serializer)
            {
                Serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
                return this;
            }

            public ISteamerSerializerProvider Build()
            {
                return new SteamerSerializerProvider(Serializer ?? throw new ArgumentNullException(nameof(Serializer)));
            }
        }
    }
}