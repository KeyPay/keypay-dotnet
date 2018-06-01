using System.Collections.Generic;
using KeyPay.Common.DomainModels.Business;
using KeyPay.Common.DomainModels.ChartOfAccounts;
using RestSharp;

namespace KeyPay.Common.ApiFunctions
{
    public class JournalServicesFunction : BaseFunction
    {
        public JournalServicesFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<string> List(int businessId)
        {
            return ApiRequest<List<string>>($"/business/{businessId}/accounts/journalservices");
        }

        public JournalServiceProviderModel Get(int businessId)
        {
            return ApiRequest<JournalServiceProviderModel>($"/business/{businessId}/accounts/journalservice");
        }

        public JournalServiceProviderModel Update(int businessId, JournalServiceProviderModel model)
        {
            return ApiRequest<JournalServiceProviderModel, JournalServiceProviderModel>($"/business/{businessId}/accounts/journalservice", model, Method.PUT);
        }

    }
}