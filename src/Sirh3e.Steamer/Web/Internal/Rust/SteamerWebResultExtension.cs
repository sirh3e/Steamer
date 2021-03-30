using Sirh3e.Rust.Result;
using Sirh3e.Steamer.Web.Errors;

namespace Sirh3e.Steamer.Web.Internal.Rust
{
    internal static class SteamerWebResultExtension
    {
        internal static Result<TOk, ISteamerWebError> FromOk<TOk>(this TOk ok)
            => Result<TOk, ISteamerWebError>.Ok(ok);

        internal static Result<TOk, ISteamerWebError> FromErr<TOk>(this ISteamerWebError error)
            => Result<TOk, ISteamerWebError>.Err(error);
    }
}