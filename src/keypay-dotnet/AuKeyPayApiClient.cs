using KeyPay.Au.ApiFunctions;
using KeyPay.Common.Auth;

namespace KeyPay
{
    public class AuKeyPayApiClient : BaseKeyPayApiClient
    {
        public AuKeyPayApiClient(string baseUrl, AuthenticationDetails authenticationDetails) : base(baseUrl, authenticationDetails)
        {
            Business = new BusinessFunction(Api);
        }

        public BusinessFunction Business { get; }
    }
}