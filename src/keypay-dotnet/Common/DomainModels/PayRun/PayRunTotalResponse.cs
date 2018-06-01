using System.Collections.Generic;

namespace KeyPay.Common.DomainModels.PayRun
{
    public class PayRunTotalResponse
    {
        public int PayRunId { get; set; }
        public Dictionary<string, PayRunTotalModel> PayRunTotals { get; set; }
    }
}