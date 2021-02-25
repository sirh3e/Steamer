using System;

namespace Sirh3e.Steamer.Core.Serializers.Providers
{
    public class SteamerSerializerStringDataProvider : ISteamerSerializerDataProvider
    {
        public SteamerSerializerStringDataProvider(string data) => Data = data ?? throw new ArgumentNullException(nameof(data));

        public string Data { get; }

        public string GetData() => Data;
    }
}