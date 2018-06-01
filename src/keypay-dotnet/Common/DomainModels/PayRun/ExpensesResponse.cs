using System.Collections.Generic;

namespace KeyPay.Common.DomainModels.PayRun
{
    public class ExpensesResponse
    {
        public ExpensesResponse()
        {
            EmployeeExpenses = new Dictionary<string, List<ExpenseModel>>();
        }
        public int PayRunId { get; set; }
        public Dictionary<string, List<ExpenseModel>> EmployeeExpenses { get; set; }
    }
}