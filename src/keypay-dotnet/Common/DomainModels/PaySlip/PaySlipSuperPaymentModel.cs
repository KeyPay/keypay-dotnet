namespace KeyPay.Common.DomainModels.PaySlip
{
    public class PaySlipSuperPaymentModel
    {
        public string FundName { get; set; }
        public string MemberNumber { get; set; }
        public decimal Amount { get; set; }
    }
}