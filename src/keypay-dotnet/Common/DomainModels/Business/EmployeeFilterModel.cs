using KeyPay.Common.Enums;

namespace KeyPay.Common.DomainModels.Business
{
    public class EmployeeFilterModel
    {
        public FilterType FilterType { get; set; }
        public FilterOperator Operator { get; set; }
        public string Value { get; set; }
    }
}