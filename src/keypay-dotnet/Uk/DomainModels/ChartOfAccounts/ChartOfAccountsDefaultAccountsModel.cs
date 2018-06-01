namespace KeyPay.Uk.DomainModels.ChartOfAccounts
{
    public class ChartOfAccountsDefaultAccountsModel : ChartOfAccountsLocationAccountsModel
    {
        public bool PaymentAccountSplitByLocation { get; set; }
        public bool PayeLiabilityAccountSplitByLocation { get; set; }
        public bool PayeExpenseSplitByLocation { get; set; }
        public bool DefaultExpenseSplitByLocation { get; set; }
        public bool EmployeeExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityExpenseSplitByLocation { get; set; }
        public bool EmployerLiabilityLiabilitySplitByLocation { get; set; }
        public bool DefaultLiabilitySplitByLocation { get; set; }
        public bool EmployerPensionLiabilitySplitByLocation { get; set; }
        public bool EmployerPensionExpenseSplitByLocation { get; set; }
        public bool NationalInsuranceLiabilitySplitByLocation { get; set; }
        public bool NationalInsuranceExpenseSplitByLocation { get; set; }
        public bool EmployeePensionLiabilitySplitByLocation { get; set; }
    }
}