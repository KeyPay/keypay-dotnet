using System.Collections.Generic;
using KeyPay.Au.DomainModels.Business;
using KeyPay.Common.ApiFunctions;
using RestSharp;

namespace KeyPay.Au.ApiFunctions
{
    public class ABAFunction : BaseFunction
    {
        public ABAFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<ABAModel> Get(int businessId)
        {
            return ApiRequest<List<ABAModel>>(string.Format("/business/{0}/ABA", businessId));
        }

        public void Update(int businessId, ABAModel model)
        {
            ApiRequest(string.Format("/business/{0}/ABA", businessId), model, Method.POST);
        }
    }
}