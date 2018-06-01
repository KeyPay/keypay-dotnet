using KeyPay.Common.DomainModels.PayRun;

namespace KeyPay.Common.ApiFunctions
{
    public class PaygAdjustmentsFunction : BaseFunction
    {
        public PaygAdjustmentsFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public PaygAdjustmentResponse List(int businessId, int payRunId)
        {
            return ApiRequest<PaygAdjustmentResponse>("/business/" + businessId + "/payrun/" + payRunId + "/paygadjustments");
        }
    }
}