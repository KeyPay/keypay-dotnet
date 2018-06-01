namespace KeyPay.Common.DomainModels.Report
{
    public class PaygReportExportModel
    {
        public string Location { get; set; }
        public string Month { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal PreTaxDeductions { get; set; }
        public decimal GrossEarningsLessPreTaxDeductions { get; set; }
        public decimal PAYG { get; set; }
    }
}