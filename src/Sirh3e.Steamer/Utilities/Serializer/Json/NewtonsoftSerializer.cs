using System;

namespace Sirh3e.Steamer.Utilities.Serializer.Json
{
    public class NewtonsoftSerializer : ISteamerSerializer
    {
        protected Func<string, Type, object> SerializeFunc;

        public NewtonsoftSerializer(Func<string, Type, object> func)
        {
            SerializeFunc = func ?? throw new ArgumentNullException(nameof(func));
        }

        public T Serialize<T>(string data)
        {
            _ = data ?? throw new ArgumentNullException(nameof(data));

            return (T)SerializeFunc(data, typeof(T));
        }
    }
}