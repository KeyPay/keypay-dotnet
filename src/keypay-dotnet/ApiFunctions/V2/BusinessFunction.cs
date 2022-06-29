using System.Collections.Generic;
using KeyPay.DomainModels.V2;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class BusinessFunction : BaseFunction
    {
        public BusinessFunction(ApiRequestExecutor api) : base(api)
        {
            ABA = new ABAFunction(api);
            JournalAccounts = new JournalAccountsFunction(api);
            JournalServices = new JournalServicesFunction(api);
            ChartOfAccounts = new ChartOfAccountsFunction(api);
            Access = new BusinessAccessFunction(api);
            ActionItems = new BusinessActionItems(api);
        }

        public ABAFunction ABA { get; set; }
        public JournalAccountsFunction JournalAccounts { get; set; }
        public JournalServicesFunction JournalServices { get; set; }
        public ChartOfAccountsFunction ChartOfAccounts { get; set; }
        public BusinessAccessFunction Access { get; set; }
        public BusinessActionItems ActionItems { get; set; }

        public BusinessModel Create(BusinessModel model)
        {
            return ApiRequest<BusinessModel, BusinessModel>("/business", model, Method.Post);
        }

        public BusinessModel Get(int id)
        {
            return ApiRequest<BusinessModel>(string.Format("/business/{0}", id));
        }

        public void Delete(int id)
        {
            ApiRequest(string.Format("/business/{0}", id), Method.Delete);
        }

        public List<BusinessModel> List()
        {
            return ApiRequest<List<BusinessModel>>(string.Format("/business"));
        }

        public SingleSignOnModel SingleSignOn(int id)
        {
            return ApiRequest<SingleSignOnModel>(string.Format("/business/{0}/singlesignon", id), Method.Post);
        }

        public EntitlementsModel Entitlements(int id)
        {
            return ApiRequest<EntitlementsModel>(string.Format("/business/{0}/entitlements", id));
        }
    }
}