using System;

namespace KeyPay.Common.DomainModels.Employee
{
    public class EmployeeDocumentModel
    {
        public int Id { get; set; }
        public string FriendlyName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Visible { get; set; }
        public int? LeaveRequestId { get; set; }
        public int? TimesheetLineId { get; set; }
    }
}