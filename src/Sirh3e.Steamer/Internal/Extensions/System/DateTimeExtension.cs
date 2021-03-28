using System;

namespace Sirh3e.Steamer.Internal.Extensions.System
{
    internal static class SteamerDateTimeExtension
    {
        public static uint ToUnixTimeStamp(this DateTime dateTime)
            => (uint)dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }
}