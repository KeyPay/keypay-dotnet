namespace KeyPay.Uk.ApiFunctions
{
    public class BusinessFunction : KeyPay.Common.ApiFunctions.BusinessFunction
    {
        public BusinessFunction(ApiRequestExecutor api) : base(api)
        {
            ChartOfAccounts = new ChartOfAccountsFunction(api);
        }

        public ChartOfAccountsFunction ChartOfAccounts { get; set; }
    }
}