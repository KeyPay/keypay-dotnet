namespace KeyPay.Au.DomainModels.ChartOfAccounts
{
    public class ChartOfAccountsLocationAccountsModel
    {
        public int? PaymentAccountId { get; set; }
        public int? PaygLiabilityAccountId { get; set; }
        public int? PaygExpenseAccountId { get; set; }
        public int? SuperannuationExpenseAccountId { get; set; }
        public int? SuperannuationLiabilityAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
    }
}