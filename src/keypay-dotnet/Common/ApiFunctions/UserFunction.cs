using KeyPay.Common.DomainModels;

namespace KeyPay.Common.ApiFunctions
{
    public class UserFunction : BaseFunction
    {
        public UserFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public UserModel Get()
        {
            var model = ApiRequest<UserModel>("/user");
            return model;
        }
    }
}