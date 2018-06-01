using System.Collections.Generic;
using KeyPay.Common.Enums;

namespace KeyPay.Common.DomainModels.Employee
{
    public class SubmitEmployeeLeaveAllowancesRequest
    {
        public IdType EmployeeIdType { get; set; }
        public IdType LeaveCategoryIdType { get; set; }
        public Dictionary<string, List<LeaveAllowanceModel>> LeaveAllowances { get; set; }
    }
}