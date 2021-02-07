using System.Text.Json;

namespace Sirh3e.Steamer.Core.Serializers.Json
{
    public interface ISteamerSystemTextJsonSerializerOptionsProvider
    {
        public JsonSerializerOptions Options { get; }
    }
}