using System.Text.Json;

namespace Sirh3e.Steamer.Web.Serializers.Json
{
    public interface ISteamerSystemTextJsonSerializerOptionsProvider
    {
        public JsonSerializerOptions Options { get; }
    }
}