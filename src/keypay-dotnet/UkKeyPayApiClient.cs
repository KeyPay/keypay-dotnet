using KeyPay.Uk.ApiFunctions;
using KeyPay.Common.Auth;

namespace KeyPay
{
    public class UkKeyPayApiClient : BaseKeyPayApiClient
    {
        public UkKeyPayApiClient(string baseUrl, AuthenticationDetails authenticationDetails) : base(baseUrl, authenticationDetails)
        {
            Business = new BusinessFunction(Api);
        }

        public BusinessFunction Business { get; }
    }
}