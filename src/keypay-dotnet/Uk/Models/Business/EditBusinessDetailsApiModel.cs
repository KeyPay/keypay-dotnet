using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Business
{
    public class EditBusinessDetailsApiModel
    {
        public int BusinessId { get; set; }
        public decimal? StandardHoursPerDay { get; set; }
        public ExternalService? Source { get; set; }
    }
}
