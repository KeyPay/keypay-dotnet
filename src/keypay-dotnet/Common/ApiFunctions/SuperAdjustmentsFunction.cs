using KeyPay.Common.DomainModels.PayRun;

namespace KeyPay.Common.ApiFunctions
{
    public class SuperAdjustmentsFunction : BaseFunction
    {
        public SuperAdjustmentsFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public SuperAdjustmentResponse List(int businessId, int payRunId)
        {
            return ApiRequest<SuperAdjustmentResponse>("/business/" + businessId + "/payrun/" + payRunId + "/superadjustments");
        }
    }
}