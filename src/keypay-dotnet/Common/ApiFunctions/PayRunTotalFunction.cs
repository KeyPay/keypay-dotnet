using KeyPay.Common.DomainModels.PayRun;

namespace KeyPay.Common.ApiFunctions
{
    public class PayRunTotalFunction : BaseFunction
    {
        public PayRunTotalFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public PayRunTotalResponse List(int businessId, int payRunId)
        {
            return ApiRequest<PayRunTotalResponse>("/business/" + businessId + "/payrun/" + payRunId + "/totals");
        }
    }
}