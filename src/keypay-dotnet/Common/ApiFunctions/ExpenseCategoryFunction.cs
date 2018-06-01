using System.Collections.Generic;
using KeyPay.Common.DomainModels.Business;
using KeyPay.Common.DomainModels.ChartOfAccounts;
using RestSharp;

namespace KeyPay.Common.ApiFunctions
{
    public class ExpenseCategoryFunction : BaseFunction
    {
        public ExpenseCategoryFunction(ApiRequestExecutor api)
            : base(api)
        {
        }

        public IList<ExpenseCategoryModel> List(int businessId)
        {
            return ApiRequest<List<ExpenseCategoryModel>>("/business/" + businessId + "/employeeexpensecategory");
        }

        public ExpenseCategoryModel Create(int businessId, ExpenseCategoryModel model)
        {
            return ApiRequest<ExpenseCategoryModel, ExpenseCategoryModel>("/business/" + businessId + "/employeeexpensecategory", model, Method.POST);
        }

        public ExpenseCategoryModel Update(int businessId, ExpenseCategoryModel model)
        {
            return ApiRequest<ExpenseCategoryModel, ExpenseCategoryModel>("/business/" + businessId + "/employeeexpensecategory/" + model.Id, model, Method.PUT);
        }

        public void Delete(int businessId, int expenseCategoryId)
        {
            ApiRequest("/business/" + businessId + "/employeeexpensecategory/" + expenseCategoryId, Method.DELETE);
        }

        public IList<JournalServiceTaxCodeModel> TaxCodes(int businessId)
        {
            return ApiRequest<List<JournalServiceTaxCodeModel>>("/business/" + businessId + "/employeeexpensecategory/taxcodes");
        }

    }
}