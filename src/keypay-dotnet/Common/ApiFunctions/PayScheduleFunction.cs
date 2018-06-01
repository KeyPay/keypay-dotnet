using System.Collections.Generic;
using KeyPay.Common.DomainModels.Business;
using RestSharp;

namespace KeyPay.Common.ApiFunctions
{
    public class PayScheduleFunction : BaseFunction
    {
        public PayScheduleFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public IList<PayScheduleModel> List(int businessId)
        {
            return ApiRequest<List<PayScheduleModel>>("/business/" + businessId + "/payschedule");
        }

        public PayScheduleModel GetById(int businessId, int payScehduleId)
        {
            return ApiRequest<PayScheduleModel>("/business/" + businessId + "/payschedule/" + payScehduleId );
        }

        public PayScheduleModel Create(int businessId, PayScheduleModel model)
        {
            return ApiRequest<PayScheduleModel, PayScheduleModel>("/business/" + businessId + "/payschedule", model, Method.POST);
        }

        public PayScheduleModel Update(int businessId, PayScheduleModel model)
        {
            return ApiRequest<PayScheduleModel, PayScheduleModel>("/business/" + businessId + "/payschedule/" + model.Id, model, Method.PUT);
        }

        public void Delete(int businessId, int payCategoryId)
        {
            ApiRequest("/business/" + businessId + "/payschedule/" + payCategoryId, Method.DELETE);
        }
    }
}