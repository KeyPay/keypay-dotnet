using KeyPay.Common.DomainModels.PayRun;
using RestSharp;

namespace KeyPay.Common.ApiFunctions
{
    public class PayRunExpenseFunction : BaseFunction
    {
        public PayRunExpenseFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public ExpensesResponse List(int businessId, int payRunId)
        {
            return ApiRequest<ExpensesResponse>("/business/" + businessId + "/payrun/" + payRunId + "/employeeexpenses");
        }

        public ExpenseModel Submit(int businessId, SubmitExpensesRequest expenses)
        {
            return ApiRequest<ExpenseModel, SubmitExpensesRequest>("/business/" + businessId + "/payrun/" + expenses.PayRunId + "/employeeexpenses", expenses, Method.POST);
        }

    }
}