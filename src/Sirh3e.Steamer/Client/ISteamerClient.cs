using Sirh3e.Steamer.Auth;

namespace Sirh3e.Steamer.Client
{
    public interface ISteamerClient
    {
        public ISteamerAuthProvider AuthProvider { get; }
    }
}