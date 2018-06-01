namespace KeyPay.Common.DomainModels.Employee
{
    public class OpeningBalancesDeductionModel
    {
        public int DeductionCategoryId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool IsRESC { get; set; }
        public bool TaxExempt { get; set; }
        public bool IsMemberVoluntary { get; set; }
    }
}