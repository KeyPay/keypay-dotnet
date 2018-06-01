namespace KeyPay.Common.DomainModels.PaySlip
{
    public class PaySlipExpenseModel
    {
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public string LocationName { get; set; }
        public string EmployeeExpenseCategoryName { get; set; }
    }
}