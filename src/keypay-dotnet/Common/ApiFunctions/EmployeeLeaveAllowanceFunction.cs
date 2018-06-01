using System.Collections.Generic;
using KeyPay.Common.DomainModels.Employee;
using RestSharp;

namespace KeyPay.Common.ApiFunctions
{
    public class EmployeeLeaveAllowanceFunction : BaseFunction
    {
        public EmployeeLeaveAllowanceFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public IList<LeaveAllowanceModel> List(int businessId, int employeeId)
        {
            return ApiRequest<List<LeaveAllowanceModel>>("/business/" + businessId + "/employee/" + employeeId + "/leaveallowances");
        }

        public void Update(int businessId, int employeeId, IList<LeaveAllowanceModel> leaveAllowances)
        {
            ApiRequest<object, IList<LeaveAllowanceModel>>("/business/" + businessId + "/employee/" + employeeId + "/leaveallowances", leaveAllowances, Method.PUT);
        }
    }
}