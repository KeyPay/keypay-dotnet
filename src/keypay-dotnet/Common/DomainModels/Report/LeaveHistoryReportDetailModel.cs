namespace KeyPay.Common.DomainModels.Report
{
    public class LeaveHistoryReportDetailModel
    {
        public string PayPeriod { get; set; }
        public string Notes { get; set; }
        public decimal LeaveAccrued { get; set; }
        public decimal LeaveTaken { get; set; }
    }
}