using KeyPay.Common.ApiFunctions;
using KeyPay.Common.Auth;

namespace KeyPay
{
    public abstract class BaseKeyPayApiClient
    {
        protected readonly ApiRequestExecutor Api;
        protected BaseKeyPayApiClient(string baseUrl, AuthenticationDetails authenticationDetails)
        {
            Api = new ApiRequestExecutor(baseUrl) {Authenticator = authenticationDetails.Authenticator};
            PayCategory = new PayCategoryFunction(Api);
            PaySchedule = new PayScheduleFunction(Api);
            Employee = new EmployeeFunction(Api);
            Location = new LocationFunction(Api);
            PayRun = new PayRunFunction(Api);
            LeaveCategory = new LeaveCategoryFunction(Api);
            Report = new ReportFunction(Api);
            Timesheet = new TimesheetFunction(Api);
            User = new UserFunction(Api);
            PayRateTemplates = new PayRateTemplateFunction(Api);
            DeductionCategory = new DeductionCategoryFunction(Api);
            ExpenseCategory = new ExpenseCategoryFunction(Api);
            WorkType = new WorkTypeFunction(Api);
            Document = new DocumentFunction(Api);
            EmployeeGroup = new EmployeeGroupFunction(Api);
            EmployingEntity = new EmployingEntityFunction(Api);
            PaymentSummary = new PaymentSummaryFunction(Api);
            RosterShift = new RosterShiftFunction(Api);
        }

        public UserFunction User { get; }
        public PayCategoryFunction PayCategory { get; }
        public PayScheduleFunction PaySchedule { get; }
        public EmployeeFunction Employee { get;  }
        public LocationFunction Location { get; }
        public WorkTypeFunction WorkType { get; }
        public PayRunFunction PayRun { get; }
        public LeaveCategoryFunction LeaveCategory { get; }
        public ReportFunction Report { get; }
        public TimesheetFunction Timesheet { get; }
        public PayRateTemplateFunction PayRateTemplates { get; }
        public DeductionCategoryFunction DeductionCategory { get; }
        public ExpenseCategoryFunction ExpenseCategory { get; }
        public EmployeeGroupFunction EmployeeGroup { get; }
        public DocumentFunction Document { get; }
        public EmployingEntityFunction EmployingEntity { get; }
        public PaymentSummaryFunction PaymentSummary { get; }
        public RosterShiftFunction RosterShift { get; }
    }
}