using System.Collections.Generic;
using KeyPay.DomainModels.V2;
using Newtonsoft.Json;
using RestSharp;

namespace KeyPay.ApiFunctions
{
    public class BaseFunction
    {
        protected readonly ApiRequestExecutor Api;

        public BaseFunction(ApiRequestExecutor api)
        {
            Api = api;
        }

        private string SanitiseUrl(string url) => url.EndsWith("&") ? url.Remove(url.Length - 1, 1) : url;

        protected void ApiRequest(string url, Method method = Method.Get)
        {
            var req = new RestRequest(SanitiseUrl(url), method);
            Api.Execute(req);
        }

        protected T ApiRequest<T>(string url, Method method = Method.Get) where T : new()
        {
            var req = new RestRequest(SanitiseUrl(url), method);
            var result = Api.Execute<T>(req);
            return result;
        }

        protected TResult ApiRequest<TResult, TInput>(string url, TInput input, Method method = Method.Get) 
            where TInput : class 
            where TResult : new()
        {
            var req = new RestRequest(SanitiseUrl(url), method);
            AddParameters(req, method, input);
            var result = Api.Execute<TResult>(req);
            return result;
        }

        private void AddParameters<TInput>(RestRequest req, Method method, TInput data) where TInput : class
        {
            if (method == Method.Get)
            {
                req.AddObject(data);
            }
            else
            {
                AddJsonBody(req, data);
            }
        }

        private void AddJsonBody<TInput>(RestRequest req, TInput input) where TInput : class
        {
            if (input == null && typeof(TInput) == typeof(string))
                req.AddJsonBody("");
            else if (input != null)
                req.AddJsonBody(input);
        }

        protected void ApiRequest(string url, object input, Method method = Method.Get)
        {
            var req = new RestRequest(SanitiseUrl(url), method);
            AddParameters(req, method, input);
            Api.Execute(req);
        }
        
        protected T ApiFileRequest<T>(string url, FileUploadModel file, Method method = Method.Post) where T : new()
        {
            var req = new RestRequest(SanitiseUrl(url), method);
            req.AddFile(file.FileName, file.File, file.FileName);
            var result = Api.Execute<T>(req);
            return result;
        }

        protected T ApiFileRequest<T>(string url, List<FileUploadModel> files, Method method = Method.Post) where T : new()
        {
            var req = new RestRequest(SanitiseUrl(url), method);
            foreach (var file in files)
            {
                req.AddFile(file.FileName, file.File, file.FileName);
            }
            var result = Api.Execute<T>(req);
            return result;
        }

        protected T ApiByteArrayRequest<T>(string url, Method method = Method.Get) where T : new()
        {
            var req = new RestRequest(SanitiseUrl(url), method);
            var response = Api.Execute(req);
            var result = JsonConvert.DeserializeObject<T>(response);
            return result;
        }
        protected byte[] ApiByteArrayRequest(string url, Method method = Method.Get)
        {
            var req = new RestRequest(SanitiseUrl(url), method);
            var result = Api.DownloadFile(req);
            return result;
        }

        protected string ApiJsonRequest(string url, Method method = Method.Get)
        {
            var req = new RestRequest(SanitiseUrl(url), method);
            var result = Api.Execute(req);
            return result;
        }

        protected T ApiJsonRequest<T>(string url, Method method = Method.Get)
        {
            var req = new RestRequest(SanitiseUrl(url), method);
            var response = Api.Execute(req);
            var result = JsonConvert.DeserializeObject<T>(response);
            return result;
        }
    }
}
