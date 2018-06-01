using System.Collections.Generic;
using KeyPay.Common.DomainModels;
using KeyPay.Common.DomainModels.Business;
using RestSharp;

namespace KeyPay.Common.ApiFunctions
{
    public class BusinessFunction : BaseFunction
    {
        public BusinessFunction(ApiRequestExecutor api) : base(api)
        {
            JournalAccounts = new JournalAccountsFunction(api);
            JournalServices = new JournalServicesFunction(api);
        }

        public JournalAccountsFunction JournalAccounts { get; set; }
        public JournalServicesFunction JournalServices { get; set; }

        public BusinessModel Create(BusinessModel model)
        {
            return ApiRequest<BusinessModel, BusinessModel>("/business", model, Method.POST);
        }

        public BusinessModel Get(int id)
        {
            return ApiRequest<BusinessModel>(string.Format("/business/{0}", id));
        }

        public void Delete(int id)
        {
            ApiRequest(string.Format("/business/{0}", id), Method.DELETE);
        }

        public List<BusinessModel> List()
        {
            return ApiRequest<List<BusinessModel>>(string.Format("/business"));
        }

        public SingleSignOnModel SingleSignOn(int id)
        {
            return ApiRequest<SingleSignOnModel>(string.Format("/business/{0}/singlesignon", id), Method.POST);
        }

        public EntitlementsModel Entitlements(int id)
        {
            return ApiRequest<EntitlementsModel>(string.Format("/business/{0}/entitlements", id));
        }
    }
}