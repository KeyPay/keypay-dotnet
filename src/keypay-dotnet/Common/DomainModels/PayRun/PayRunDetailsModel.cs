using System.Collections.Generic;

namespace KeyPay.Common.DomainModels.PayRun
{
    public class PayRunDetailsModel
    {
        public PayRunModel PayRun { get; set; }
        public List<PayRunTotalDetailsModel> PayRunTotals { get; set; }
        public PayRunGrandTotalModel GrandTotal { get; set; }
    }
}