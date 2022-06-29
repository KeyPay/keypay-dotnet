using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyPay.DomainModels.V2;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class UnavailabilityFunction : BaseFunction
    {
        public UnavailabilityFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public List<UnavailabilityModel> List(int businessId, UnavailabilityFilterModel filterModel)
        {
            return ApiRequest<List<UnavailabilityModel>,UnavailabilityFilterModel>($"/business/{businessId}/unavailability", filterModel);
        }

        public UnavailabilityModel Get(int businessId, int unavailabilityId)
        {
            return ApiRequest<UnavailabilityModel>($"/business/{businessId}/unavailability/{unavailabilityId}", Method.Get);
        }

        public UnavailabilityModel Create(int businessId, UnavailabilityModel model)
        {
            return ApiRequest<UnavailabilityModel, UnavailabilityModel>($"/business/{businessId}/unavailability/", model, Method.Post);
        }

        public UnavailabilityModel Update(int businessId, int unavailabilityId, UnavailabilityModel model)
        {
            return ApiRequest<UnavailabilityModel, UnavailabilityModel>($"/business/{businessId}/unavailability/{unavailabilityId}", model, Method.Put);
        }

        public void Delete(int businessId, int unavailabilityId)
        {
            ApiRequest($"/business/{businessId}/unavailability/{unavailabilityId}", Method.Delete);
        }
    }
}
