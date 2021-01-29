using System;

namespace Sirh3e.Steamer.Core.Parameter
{
    public class SteamerStringParameter : ISteamerParameter<string>
    {
        public SteamerStringParameter(string name, string value)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public bool Required { get; }
        public string Name { get; }
        public string Value { get; set; }

        public void Deconstruct(out bool required, out string name, out string value)
        {
            throw new NotImplementedException();
        }

        public void Deconstruct(out bool required, out string name, out object value)
        {
            throw new NotImplementedException();
        }

        public void Deconstruct(out string name, out string value)
        {
            name = Value;
            value = Value;
        }

        public void Deconstruct(out string name, out object value)
        {
            Deconstruct(out var t, out string t1);

            name = t;
            value = t1;
        }

        object ISteamerParameter.Value
        {
            get => Value;
            set => Value = value as string;
        }
    }
}