namespace KeyPay.Au.DomainModels.ChartOfAccounts
{
    public class ChartOfAccountsDefaultAccountsModel : ChartOfAccountsLocationAccountsModel
    {
        public bool PaymentAccountSplitByLocation { get; set; }
        public bool PaygLiabilityAccountSplitByLocation { get; set; }
        public bool PaygExpenseSplitByLocation { get; set; }
        public bool SuperannuationExpenseSplitByLocation { get; set; }
        public bool SuperannuationLiabilitySplitByLocation { get; set; }
        public bool DefaultExpenseSplitByLocation { get; set; }
        public bool EmployeeExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityLiabilitySplitByLocation { get; set; }
        public bool DefaultLiabilitySplitByLocation { get; set; }
    }
}