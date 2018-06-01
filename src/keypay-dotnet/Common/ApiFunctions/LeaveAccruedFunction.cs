using KeyPay.Common.DomainModels.PayRun;

namespace KeyPay.Common.ApiFunctions
{
    public class LeaveAccruedFunction : BaseFunction
    {
        public LeaveAccruedFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public LeaveAccrualResponse List(int businessId, int payRunId)
        {
            return ApiRequest<LeaveAccrualResponse>("/business/" + businessId + "/payrun/" + payRunId + "/leaveaccrued");
        }
    }
}