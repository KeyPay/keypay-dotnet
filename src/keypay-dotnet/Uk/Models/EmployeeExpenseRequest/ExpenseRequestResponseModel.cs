using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmployeeExpenseRequest
{
    public class ExpenseRequestResponseModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public List<ExpenseRequestLineItemModel> LineItems { get; set; }
        public List<AttachmentModel> Attachments { get; set; }
        public string StatusUpdatedByUser { get; set; }
        public string StatusUpdateNotes { get; set; }
        public DateTime DateStatusUpdated { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
