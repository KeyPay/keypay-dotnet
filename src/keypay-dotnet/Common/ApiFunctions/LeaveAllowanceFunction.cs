using System.Collections.Generic;
using KeyPay.Common.DomainModels.Employee;
using RestSharp;

namespace KeyPay.Common.ApiFunctions
{
    public class LeaveAllowanceFunction : BaseFunction
    {
        public LeaveAllowanceFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public Dictionary<string, List<LeaveAllowanceModel>> List(int businessId)
        {
            return ApiRequest<Dictionary<string, List<LeaveAllowanceModel>>>("/business/" + businessId + "/leaveallowances");
        }

        public void Update(int businessId, SubmitEmployeeLeaveAllowancesRequest leaveAllowances)
        {
            ApiRequest<object, SubmitEmployeeLeaveAllowancesRequest>("/business/" + businessId + "/leaveallowances", leaveAllowances, Method.PUT);
        }
    }
}