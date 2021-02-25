namespace Sirh3e.Steamer.Core.Parameter.Types
{
    public class SteamerU64Parameter : SteamerParameter<ulong>
    {
        public SteamerU64Parameter(string name, bool required = true, ulong value = 0) : base(name, value, required)
        {
        }

        public override string GetValueFromQueryString() => Value.ToString();
    }
}