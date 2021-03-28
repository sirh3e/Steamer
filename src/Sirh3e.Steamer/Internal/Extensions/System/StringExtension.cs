namespace Sirh3e.Steamer.Internal.Extensions.System
{
    public static class StringExtension
    {
        public static string? IsNullOrEmpty(this string @string)
            => string.IsNullOrEmpty(@string) ? null : @string;
    }
}