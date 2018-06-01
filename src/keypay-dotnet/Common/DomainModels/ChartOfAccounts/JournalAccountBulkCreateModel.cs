using System.Collections.Generic;
using KeyPay.Common.DomainModels.Business;

namespace KeyPay.Common.DomainModels.ChartOfAccounts
{
    public class JournalAccountBulkCreateModel
    {
        public List<string> ErrorMessages { get; set; }
        public List<JournalAccountModel> CreatedJournalAccounts { get; set; }
    }
}