using System.Collections.Generic;
using KeyPay.Common.Enums;

namespace KeyPay.Common.DomainModels.Business
{
    public class EmployeeGroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FilterCombinationStrategy FilterCombinationStrategy { get; set; }
        public IList<EmployeeFilterModel> Filters { get; set; }
    }
}