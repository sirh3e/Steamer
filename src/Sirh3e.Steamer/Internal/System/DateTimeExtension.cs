using System;

namespace Sirh3e.Steamer.Core.Extensions.Internal.System
{
    internal static class DateTimeExtension
    {
        public static uint ToUnixTimeStamp(this DateTime dateTime) => (uint)dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }
}