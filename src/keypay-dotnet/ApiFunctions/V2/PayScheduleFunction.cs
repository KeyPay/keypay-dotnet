using System.Collections.Generic;
using KeyPay.DomainModels.V2.Business;
using RestSharp;

namespace KeyPay.ApiFunctions.V2
{
    public class PayScheduleFunction : BaseFunction
    {
        public PayScheduleFunction(ApiRequestExecutor api) : base(api)
        {
        }

        public IList<PayScheduleModel> List(int businessId)
        {
            return ApiRequest<List<PayScheduleModel>>($"/business/{businessId}/payschedule");
        }

        public PayScheduleModel GetById(int businessId, int payScehduleId)
        {
            return ApiRequest<PayScheduleModel>($"/business/{businessId}/payschedule/{payScehduleId}");
        }

        public PayScheduleModel Create(int businessId, PayScheduleModel model)
        {
            return ApiRequest<PayScheduleModel, PayScheduleModel>($"/business/{businessId}/payschedule", model, Method.Post);
        }

        public PayScheduleModel Update(int businessId, PayScheduleModel model)
        {
            return ApiRequest<PayScheduleModel, PayScheduleModel>($"/business/{businessId}/payschedule/{model.Id}", model, Method.Put);
        }

        public PayScheduleMetaDataModel MetaData(int businessId)
        {
            return ApiRequest<PayScheduleMetaDataModel>($"/business/{businessId}/payschedule/metadata");
        }

        public void Delete(int businessId, int payCategoryId)
        {
            ApiRequest($"/business/{businessId}/payschedule/{payCategoryId}", Method.Delete);
        }

        public PayScheduleDateForecastResultApiModel GetNextPayDate(int businessId, int payScheduleId)
        {
            return ApiRequest<PayScheduleDateForecastResultApiModel>($"/business/{businessId}/payschedule/{payScheduleId}/nextpaydate");
        }
    }
}