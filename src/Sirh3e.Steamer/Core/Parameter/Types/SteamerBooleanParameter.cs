namespace Sirh3e.Steamer.Core.Parameter.Types
{
    public class SteamerBooleanParameter : SteamerParameter<bool>
    {
        public SteamerBooleanParameter(string name, bool required = true, bool value = false) : base(name, value,
            required)
        {
        }

        public override string GetValueFromQueryString() =>
            (Value
                ? 1
                : 0).ToString();
    }
}