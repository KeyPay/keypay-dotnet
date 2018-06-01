using KeyPay.Common.Enums;

namespace KeyPay.Common.DomainModels.ChartOfAccounts
{
    public class JournalAccountModel
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public ExternalAccountType AccountType { get; set; }
        public string ExternalReferenceId { get; set; }
    }
}