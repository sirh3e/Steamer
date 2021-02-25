namespace Sirh3e.Steamer.Core.Parameter.Types
{
    public class SteamerU32Parameter : SteamerParameter<uint>
    {
        public SteamerU32Parameter(string name, bool required = true, uint value = 0) : base(name, value, required)
        {
        }

        public override string GetValueFromQueryString() => Value.ToString();
    }
}