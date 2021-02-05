using System.Text.Json;

namespace Sirh3e.Steamer.Web.Serializers.Json
{
    public interface IJsonSerializerDeserializeOptionsProvider
    {
        public JsonSerializerOptions Options { get; }
    }
}