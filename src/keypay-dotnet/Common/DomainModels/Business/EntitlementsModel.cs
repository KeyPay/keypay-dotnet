using System;
using System.Collections.Generic;

namespace KeyPay.Common.DomainModels.Business
{
    public class EntitlementsModel
    {
        public string PlanName { get; set; }
        public DateTime TrialExpiryDate { get; set; }
        public IList<EntitlementFeatureModel> Features { get; set; }
    }
}