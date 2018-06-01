namespace KeyPay.Common.DomainModels.PaySlip
{
    public class PaySlipLeaveModel
    {
        public string LeaveCategory { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}