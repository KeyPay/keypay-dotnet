using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using KeyPay.Exceptions;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using RestClientExtensions = RestSharp.Serializers.NewtonsoftJson.RestClientExtensions;

namespace KeyPay
{
    public class ApiRequestExecutor
    {
        public string Token { get; set; }
        public IAuthenticator Authenticator { get; set; }

        private readonly string baseUrl;

        public ApiRequestExecutor(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = GetClient(request);
            var response = client.Execute(request);
            if (response.ErrorException != null)
                throw response.ErrorException;
            if ((int) response.StatusCode >= 400)
            {
                throw new KeyPayHttpException(response.StatusCode, response.StatusDescription, request.Method, request.Resource, response.Content);
            }
            var result = JsonConvert.DeserializeObject<T>(response.Content);
            return result;
        }

        public string Execute(RestRequest request)
        {
            var client = GetClient(request);
            var response = client.Execute(request);
            HandleResponse(response, request.Method, request.Resource);
            return response.Content;
        }
        public byte[] DownloadFile(RestRequest request)
        {
            var client = GetClient(request);
            var response = client.DownloadData(request);
            return response;
        }

        private RestClient GetClient(RestRequest request)
        {
            var options = new RestClientOptions
            {
                BaseUrl = new Uri(baseUrl),
                MaxTimeout = 600000, // 10 min timeout for long EI queries
                Authenticator = Authenticator,
            };

            var client = new RestClient(options, configureSerialization: config => config.UseNewtonsoftJson());
            request.OnBeforeDeserialization = resp => HandleResponse(resp, request.Method, request.Resource);
            return client;
        }

        private static void HandleResponse(RestResponse resp, Method requestMethod, string requestResource)
        {
            if (resp.ErrorException != null)
                throw resp.ErrorException;
            if (resp.StatusCode == HttpStatusCode.Unauthorized)
                throw new TokenExpiredException(resp.StatusDescription);
            if (resp.StatusCode >= HttpStatusCode.BadRequest && resp.StatusCode <= HttpStatusCode.InternalServerError)
                throw new KeyPayHttpException(resp.StatusCode, resp.StatusDescription, requestMethod, requestResource, resp.Content);
        }
    }
}