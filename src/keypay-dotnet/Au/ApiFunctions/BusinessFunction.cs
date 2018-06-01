namespace KeyPay.Au.ApiFunctions
{
    public class BusinessFunction : KeyPay.Common.ApiFunctions.BusinessFunction
    {
        public BusinessFunction(ApiRequestExecutor api) : base(api)
        {
            ABA = new ABAFunction(api);
            ChartOfAccounts = new ChartOfAccountsFunction(api);
        }

        public ABAFunction ABA { get; }
        public ChartOfAccountsFunction ChartOfAccounts { get; }
    }
}