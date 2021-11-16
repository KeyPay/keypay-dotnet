using System;
using System.ComponentModel;

namespace KeyPay.Enums
{
    [Flags]
    public enum UserPermission : long
    {
        [Description("Approve Timesheets")]
        ApproveTimesheets,
        [Description("Approve Leave Requests")]
        ApproveLeaveRequests,
        [Description("Create Timesheets")]
        CreateTimesheets,
        [Description("Create Leave Requests")]
        CreateLeaveRequests,
        [Description("View Leave Requests")]
        ViewLeaveRequests,
        [Description("Manage Employee Rosters")]
        ManageRosters,
        [Description("View Employee Rosters")]
        ViewRosters,
        [Description("View Shift Costs")]
        ViewShiftCosts,
        [Description("View Employee Expenses")]
        ViewExpenses,
        [Description("Create Employee Expenses")]
        CreateExpenses,
        [Description("Approve Expenses")]
        ApproveExpenses,
        [Description("Create Tasks")]
        CreateTasks,
        [Description("View Employee Documents")]
        ViewEmployeeDocuments,
        [Description("Manage Employee Documents")]
        ManageEmployeeDocuments,
        [Description("View Employee Qualifications")]
        ViewEmployeeQualifications,
        [Description("Manage Employee Qualifications")]
        ManageEmployeeQualifications,
        [Description("Initiate Self Setup")]
        InitiateEmployeeSelfSetup,
        [Description("Add Employee From Kiosk")]
        AddEmployeeFromKiosk,
        [Description("View Employee Details")]
        ViewEmployeeDetails,
        [Description("Edit Basic Employee Details")]
        EditBasicEmployeeDetails,
        [Description("Edit All Employee Details")]
        EditAllEmployeeDetails,
    }
}