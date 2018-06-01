using System.Collections.Generic;
using KeyPay.Common.DomainModels.Business;

namespace KeyPay.Common.ApiFunctions
{
    public class EmployeeGroupFunction : BaseFunction
    {
        public EmployeeGroupFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<EmployeeGroupModel> List(int businessId)
        {
            return ApiRequest<List<EmployeeGroupModel>>("/business/" + businessId + "/employeegroup");
        }
    }
}