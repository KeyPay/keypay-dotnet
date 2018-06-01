using RestSharp.Authenticators;

namespace KeyPay.Common.Auth
{
    public abstract class AuthenticationDetails
    {
        public abstract IAuthenticator Authenticator { get; }
    }
}