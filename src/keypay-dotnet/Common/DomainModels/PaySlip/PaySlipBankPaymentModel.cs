namespace KeyPay.Common.DomainModels.PaySlip
{
    public class PaySlipBankPaymentModel
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string LodgementReference { get; set; }
        public string BSB { get; set; }
        public decimal Amount { get; set; }
    }
}