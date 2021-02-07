namespace Sirh3e.Steamer.Core.Parameter
{
    public interface ISteamerParameter
    {
        public bool Required { get; }
        public string Name { get; }
        public object Value { get; set; }
        public string GetValueFromQueryString();
        public void Deconstruct(out bool required, out string name, out object value);
    }

    public interface ISteamerParameter<TValue> : ISteamerParameter
    {
        public new TValue Value { get; }

        public void Deconstruct(out bool required, out string name, out TValue value);
    }
}