using System;

namespace Sirh3e.Steamer.Core.Parameter
{
    public abstract class SteamerParameter<TType> : ISteamerParameter<TType>
    {
        public SteamerParameter(string name, TType value, bool required = true)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Value = value ?? throw new ArgumentNullException(nameof(value));
            Required = required;
        }

        public bool Required { get; }
        public string Name { get; }
        public TType Value { get; protected set; }

        object ISteamerParameter.Value
        {
            get => Value;
            set => Value = (TType)value;
        }

        public abstract string GetValueFromQueryString();

        public void Deconstruct(out bool required, out string name, out TType value) => (required, name, value) = (Required, Name, Value);

        public void Deconstruct(out bool required, out string name, out object value) => (required, name, value) = (Required, Name, Value);
    }
}