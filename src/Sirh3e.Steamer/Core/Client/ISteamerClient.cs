using Sirh3e.Steamer.Core.Auth;

namespace Sirh3e.Steamer.Core.Client
{
    public interface ISteamerClient
    {
        public ISteamerAuthProvider AuthProvider { get; }
    }
}