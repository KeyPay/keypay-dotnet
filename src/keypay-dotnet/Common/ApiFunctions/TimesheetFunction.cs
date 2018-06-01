using System.Collections.Generic;
using KeyPay.Common.DomainModels.Business;
using KeyPay.Common.DomainModels.Custom;
using RestSharp;

namespace KeyPay.Common.ApiFunctions
{
    public class TimesheetFunction : BaseFunction
    {
        public TimesheetFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public IList<TimesheetModel> List(int businessId)
        {
            return ApiRequest<List<TimesheetModel>>($"/business/{businessId}/timesheet");
        }

        public IList<PayrollExport> GetByPayRunId(int businessId, int payRunId)
        {
            return ApiRequest<List<PayrollExport>>($"/business/{businessId}/payrun/{payRunId}/timesheetlines");
        }

        public void Create(int businessId, SubmitTimesheetRequest timesheetRequest)
        {
            ApiRequest($"/business/{businessId}/timesheet/bulk/", timesheetRequest, Method.PUT);
        }

        public IndividualTimesheetModel CreateTimesheetLine(int businessId, IndividualTimesheetModel timesheetLine)
        {
            return ApiRequest<IndividualTimesheetModel, IndividualTimesheetModel>($"/business/{businessId}/timesheet/", timesheetLine, Method.POST);
        }

        public IndividualTimesheetModel UpdateTimesheetLine(int businessId, IndividualTimesheetModel timesheetLine)
        {
            return ApiRequest<IndividualTimesheetModel, IndividualTimesheetModel>($"/business/{businessId}/timesheet/{timesheetLine.Id}", timesheetLine, Method.PUT);
        }
    }
}