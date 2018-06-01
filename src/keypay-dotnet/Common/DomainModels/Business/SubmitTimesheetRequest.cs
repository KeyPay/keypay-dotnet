using System;
using System.Collections.Generic;
using KeyPay.Common.Enums;

namespace KeyPay.Common.DomainModels.Business
{
    public class SubmitTimesheetRequest
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool Approved { get; set; }
        public IdType EmployeeIdType { get; set; }
        public IdType LocationIdType { get; set; }
        public IdType WorkTypeIdType { get; set; }
        public Dictionary<string,List<TimesheetModel>> Timesheets { get; set; }
    }
}