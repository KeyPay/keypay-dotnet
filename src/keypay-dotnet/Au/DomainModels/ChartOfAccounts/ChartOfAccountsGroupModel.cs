using System.Collections.Generic;
using KeyPay.Common.DomainModels.ChartOfAccounts;

namespace KeyPay.Au.DomainModels.ChartOfAccounts
{
    public class ChartOfAccountsGroupModel
    {
        public ChartOfAccountsDefaultAccountsModel DefaultAccounts { get; set; }
        public List<ChartOfAccountsCategoryModel> PayCategories { get; set; }
        public List<ChartOfAccountsLiabilityCategoryModel> DeductionCategories { get; set; }
        public List<ChartOfAccountsCategoryModel> EmployeeExpenseCategories { get; set; }
        public List<ChartOfAccountsLiabilityCategoryModel> EmployerLiabilityCategories { get; set; }
    }
}