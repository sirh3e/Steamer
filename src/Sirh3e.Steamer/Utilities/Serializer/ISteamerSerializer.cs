namespace Sirh3e.Steamer.Utilities.Serializer {
    public interface ISteamerSerializer {
        public T Serialize<T>(ISteamerSerializerDataProvider provider);
    }
}