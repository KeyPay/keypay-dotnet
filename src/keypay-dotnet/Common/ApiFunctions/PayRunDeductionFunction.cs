using KeyPay.Common.DomainModels.PayRun;
using RestSharp;

namespace KeyPay.Common.ApiFunctions
{
    public class PayRunDeductionFunction : BaseFunction
    {
        public PayRunDeductionFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public DeductionsResponse List(int businessId, int payRunId)
        {
            return ApiRequest<DeductionsResponse>("/business/" + businessId + "/payrun/" + payRunId + "/deductions");
        }

        public DeductionsResponse List(int businessId, int payRunId, int employeeId)
        {
            return ApiRequest<DeductionsResponse>("/business/" + businessId + "/payrun/" + payRunId + "/deductions/" + employeeId);
        }

        public DeductionModel Submit(int businessId, SubmitDeductionsRequest deductions)
        {
            return ApiRequest<DeductionModel, SubmitDeductionsRequest>("/business/" + businessId + "/payrun/" + deductions.PayRunId + "/deductions", deductions, Method.POST);
        }

    }
}