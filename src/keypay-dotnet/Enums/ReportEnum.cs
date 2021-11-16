using System.ComponentModel;

namespace KeyPay.Enums
{
    public enum ReportEnum : long
    {
        [Description(ReportName.DetailedActivity)]
        DetailedActivityReport = 1,

        [Description(ReportName.PayRunComparison)]
        PayRunComparisonReport = 2,

        [Description(ReportName.SuperContributions)]
        SuperContributionsReport = 3,

        [Description(ReportName.OrdinaryTimeEarnings)]
        OrdinaryTimeEarningsReport = 4,

        [Description(ReportName.Deductions)]
        DeductionsReport = 5,

        [Description(ReportName.PayrollTax)]
        PayrollTaxReport = 6,

        [Description(ReportName.Paygw)]
        PaygReport = 7,

        [Description(ReportName.PayCategories)]
        PayCategoriesReport = 8,

        [Description(ReportName.PayRunAudit)]
        PayRunAuditReport = 9,

        [Description(ReportName.Costing)]
        CostingReport = 10,

        [Description(ReportName.Timesheets)]
        TimesheetReport = 11,

        [Description(ReportName.Expenses)]
        ExpensesReport = 12,

        [Description(ReportName.PaymentHistory)]
        PaymentHistoryReport = 13,

        [Description(ReportName.LeaveBalances)]
        LeaveBalancesReport = 14,

        [Description(ReportName.LeaveLiability)]
        LeaveLiabilityReport = 15,

        [Description(ReportName.LeaveHistory)]
        LeaveHistoryReport = 16,

        [Description(ReportName.EmployeeBirthday)]
        BirthdayReport = 17,

        [Description(ReportName.EmployeeDetails)]
        EmployeeDetailsReport = 18,

        [Description(ReportName.UnpaidEmployees)]
        UnpaidEmployeesReport = 19,

        [Description(ReportName.EmployeeQualifications)]
        QualificationsReport = 20,

        [Description(ReportName.EmployeeSatisfaction)]
        EmployeeSatisfactionReport = 21,

        [Description(ReportName.Attendance)]
        AttendanceReport = 22,

        [Description(ReportName.EmergencyContacts)]
        EmergencyContactsReport = 23,

        [Description(ReportName.EmployerLiabilities)]
        EmployerLiabilitiesReport = 24,

        [Description(ReportName.PayRunVariance)]
        PayRunVarianceReport = 25,

        [Description(ReportName.EmployeeDetailsAudit)]
        EmployeeDetailsAuditReport = 26,

        [Description(ReportName.GrossToNet)]
        GrossToNetReport = 27,

        [Description(ReportName.LiveView)]
        LiveView = 28,

        [Description(ReportName.Tasks)]
        TasksReport = 29,

        [Description(ReportName.ShiftSwapping)]
        ShiftSwappingReport = 30,

        [Description(ReportName.PensionContributions)]
        PensionContributionsReport = 31,

        [Description(ReportName.EmployerPaymentSummary)]
        EmployerPaymentSummaryReport = 32,

        [Description(ReportName.PayRunInclusions)]
        PayRunInclusionsReport = 33,

        [Description(ReportName.P32)]
        P32Report = 34,

        [Description(ReportName.PaySlip)]
        PaySlipReport = 35,

        [Description(ReportName.PaymentFile)]
        PaymentFileReport = 36,

        [Description(ReportName.Journal)]
        JournalReport = 37,

        [Description(ReportName.IrdEmployeeDetails)]
        IrdEmployeeDetailsReport = 38,

        [Description(ReportName.PayDayFiling)]
        PayDayFilingReport = 39,

        [Description(ReportName.KiwiSaver)]
        KiwiSaverReport = 40,

        [Description(ReportName.Paye)]
        PayeReport = 41,

        [Description(ReportName.KiwiSaverEmploymentDetails)]
        KiwiSaverEmploymentDetailsReport = 42,

        [Description(ReportName.EmployerDeductions)]
        EmployerDeductions = 43,

        [Description(ReportName.RosterTimesheetComparison)]
        RosterTimesheetComparisonReport = 44,

        [Description(ReportName.CpfLodgement)]
        CpfLodgementReport = 45,

        [Description(ReportName.Withholding)]
        WithholdingReport = 46,

        [Description(ReportName.EsctRate)]
        EsctRateReport = 47,

        [Description(ReportName.JobKeeperEligibility)]
        JobKeeperEligibilityReport = 48,

        [Description(ReportName.EarningsCertificate)]
        EarningsCertificate = 49,

        [Description(ReportName.Ir8A)]
        Ir8AReport = 50,

        [Description(ReportName.ExcessCpfContributions)]
        ExcessCpfContributionsReport = 51,

        [Description(ReportName.BenefitsInKind)]
        BenefitsInKindReport = 52,

        [Description(ReportName.ShareOptions)]
        ShareOptionsReport = 53,

        [Description(ReportName.Cp39)]
        Cp39Report = 54,

        [Description(ReportName.EAForm)]
        EAFormReport = 55,

        [Description(ReportName.PCB2Form)]
        PCB2FormReport = 56,

        [Description(ReportName.IrasLodgement)]
        IrasReport = 57,

        [Description(ReportName.IrasLodgementDetails)]
        IrasLodgementReport = 58,

        [Description(ReportName.PayRunExportReport)]
        PayRunExportReport = 59,

        [Description("JobMaker Eligibility Report")]
        JobMakerEligibilityReport = 60,

        [Description(ReportName.EpfKwsp6BorangA)]
        EpfKwsp6BorangA = 61,

        [Description(ReportName.EpfKwsp3Registration)]
        EpfKwsp3Registration = 62,

        [Description(ReportName.MyBenefitsInKind)]
        MyBenefitsInKindReport = 63,

        [Description(ReportName.EmployeeBenefits)]
        EmployeeBenefitsReport = 64,

        [Description("Benefits NI Summary Report")]
        BenefitsNiReport = 65,

        [Description(ReportName.SocsoForm2)]
        SocsoForm2 = 66,

        [Description(ReportName.SocsoFormSip2a)]
        SocsoFormSip2a = 67,

        [Description(ReportName.SocsoForm8a)]
        SocsoForm8a = 68,

        [Description(ReportName.PcbWithholding)]
        PcbWithholdingReport = 69,

        [Description(ReportName.SocsoForm3)]
        SocsoForm3 = 70,

        [Description(ReportName.IrbFormCp22)]
        IrbFormCp22 = 71,

        [Description(ReportName.IrbFormCp22a)]
        IrbFormCp22a = 72,

        [Description(ReportName.CompanyCars)]
        CompanyCarsReport = 73,

        [Description(ReportName.P11D)]
        P11D = 74,

        [Description(ReportName.P11Db)]
        P11Db = 75,

        [Description(ReportName.EmployeeCars)]
        EmployeeCarsReport = 76,

        [Description(ReportName.P46Car)]
        P46Car = 77,

        [Description(ReportName.IrbFormCp8d)]
        IrbFormCp8d = 78,

        [Description(ReportName.DocumentAcknowledgements)]
        DocumentAcknowledgementsReport = 79,
    }
}