namespace KeyPay.Uk.DomainModels.ChartOfAccounts
{
    public class ChartOfAccountsLocationAccountsModel
    {
        public int? PaymentAccountId { get; set; }
        public int? PayeLiabilityAccountId { get; set; }
        public int? PayeExpenseAccountId { get; set; }
        public int? DefaultExpenseAccountId { get; set; }
        public int? EmployeeExpenseAccountId { get; set; }
        public int? EmployerLiabilityExpenseAccountId { get; set; }
        public int? EmployerLiabilityLiabilityAccountId { get; set; }
        public int? DefaultLiabilityAccountId { get; set; }
        public int? EmployerPensionLiabilityAccountId { get; set; }
        public int? EmployerPensionExpenseAccountId { get; set; }
        public int? NationalInsuranceLiabilityAccountId { get; set; }
        public int? NationalInsuranceExpenseAccountId { get; set; }
        public int? EmployeePensionLiabilityAccountId { get; set; }
    }
}