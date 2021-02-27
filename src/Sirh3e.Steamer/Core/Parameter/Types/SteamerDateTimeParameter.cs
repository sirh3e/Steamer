using System;
using Sirh3e.Steamer.Core.Extensions.Internal.System;

namespace Sirh3e.Steamer.Core.Parameter.Types
{
    public class SteamerDateTimeParameter : SteamerParameter<DateTime>
    {
        public SteamerDateTimeParameter(string name, DateTime value, bool required = true) : base(name, value, required)
        {
        }

        public override string GetValueFromQueryString()
        {
            return Value.ToUnixTimeStamp().ToString();
        }
    }
}