using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayRun
{
    public class UkSspApiResponseModel
    {
        public int? Id { get; set; }
        public SspCalculationStatusEnum Status { get; set; }
        public IList<StatutoryLeaveLogEvent> Log { get; set; }
    }
}
