using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Employee
{
    public class UkSmpDataApiModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime BabyDueDate { get; set; }
        public decimal WeeksPaid { get; set; }
        public decimal WeeksToPay { get; set; }
        public DateTime? PrevSmpStartDate { get; set; }
        public DateTime? PrevSmpEndDate { get; set; }
        public decimal? AverageWeeklyEarningsOverride { get; set; }
        public decimal? EmployerPensionProtection { get; set; }
        public IList<UkSmpApiModel> Smp { get; set; }
    }
}
