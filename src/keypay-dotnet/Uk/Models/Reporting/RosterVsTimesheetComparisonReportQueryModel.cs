using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class RosterVsTimesheetComparisonReportQueryModel
    {
        public int? EmployeeId { get; set; }
        public bool IncludeCosts { get; set; }
        public IList<TimesheetLineStatusType> TimesheetStatuses { get; set; }
        public int? WorkTypeId { get; set; }
        public int RosterLocationId { get; set; }
        public int TimesheetLocationId { get; set; }
        public IList<RosterShiftStatus> RosterStatuses { get; set; }
        public int PayScheduleId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
    }
}
