namespace KeyPay.Common.DomainModels.ChartOfAccounts
{
    public class ChartOfAccountsLocationCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ExpenseAccountId { get; set; }
    }
}