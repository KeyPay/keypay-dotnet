namespace KeyPay.DomainModels.V2.Report
{
    public class WithholdingReportExportModel
    {
        public string Location { get; set; }
        public string Month { get; set; }
        public decimal GrossEarnings { get; set; }
        public decimal WithholdingTaxAmount { get; set; }
        public decimal ClearanceTaxAmount { get; set; }
    }
}