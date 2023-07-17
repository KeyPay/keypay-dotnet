using System;

namespace KeyPay.DomainModels.V2.Business
{
    public class PayScheduleDateForecastResultApiModel
    {
        public int PayScheduleId { get; set; }       
        public DateTime? NextScheduledPaidDate { get; set; }
        public DateTime? NextScheduledFromDate { get; set; }
        public DateTime? NextScheduledToDate { get; set; }
    }
}