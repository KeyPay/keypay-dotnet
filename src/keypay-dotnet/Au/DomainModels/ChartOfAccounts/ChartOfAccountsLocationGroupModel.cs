using System.Collections.Generic;
using KeyPay.Common.DomainModels.ChartOfAccounts;

namespace KeyPay.Au.DomainModels.ChartOfAccounts
{
    public class ChartOfAccountsLocationGroupModel
    {
        public int LocationId { get; set; }
        public ChartOfAccountsLocationAccountsModel DefaultAccounts { get; set; }
        public List<ChartOfAccountsLocationCategoryModel> PayCategories { get; set; }
        public List<ChartOfAccountsLiabilityLocationCategoryModel> DeductionCategories { get; set; }
        public List<ChartOfAccountsLocationCategoryModel> EmployeeExpenseCategories { get; set; }
        public List<ChartOfAccountsLiabilityLocationCategoryModel> EmployerLiabilityCategories { get; set; }
    }
}