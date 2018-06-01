namespace KeyPay.Common.DomainModels.PaySlip
{
    public class PaySlipDeductionModel
    {
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public string TaxStatus { get; set; }
        public string Name { get; set; }
    }
}