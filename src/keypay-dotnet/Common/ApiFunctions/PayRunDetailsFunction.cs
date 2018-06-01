using KeyPay.Common.DomainModels.PayRun;

namespace KeyPay.Common.ApiFunctions
{
    public class PayRunDetailsFunction : BaseFunction
    {
        public PayRunDetailsFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public PayRunDetailsModel Get(int businessId, int payRunId)
        {
            return ApiRequest<PayRunDetailsModel>("/business/" + businessId + "/payrun/" + payRunId + "/details");
        }
    }
}