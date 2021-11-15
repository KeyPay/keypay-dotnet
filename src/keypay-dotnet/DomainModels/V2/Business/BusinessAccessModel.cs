using System.Collections.Generic;
using KeyPay.Enums;

namespace KeyPay.DomainModels.V2.Business
{
    public class AccessModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class EmployeeAccessModel : AccessModel
    {

    }

    public class CreateEmployeeAccessModel : AccessModel
    {
        public bool SuppressNotificationEmails { get; set; }
    }

    public class BusinessAccessModel : AccessModel
    {
        public RelatedUserType AccessType { get; set; }
        public IList<EmployeeGroupAccessModel> EmployeeGroups { get; set; }
        public IList<LocationAccessModel> LocationAccess { get; set; }
        public ReportAccessModel Reports { get; set; }
        public KioskAccessModel KioskAccess { get; set; }
    }

    public class CreateBusinessAccessModel : BusinessAccessModel
    {
        public bool SuppressNotificationEmails { get; set; }
    }

    public class EmployeeGroupAccessModel
    {
        public int EmployeeGroupId { get; set; }
        public UserPermission Permissions { get; set; }
    }

    public class LocationAccessModel
    {
        public LocationRestrictionFilterTypeEnum FilterType { get; set; }
        public List<int> LocationIds { get; set; }
        public UserPermission Permissions { get; set; }
    }

    public class ReportAccessModel
    {
        public ReportAccessType AccessType { get; set; }
        public string SpecificReports { get; set; }
        public bool NoReportingRestriction { get; set; }
    }

    public class KioskAccessModel
    {
        public List<int> Kiosks { get; set; }
        public KioskAccessType AccessType { get; set; }
        public UserPermission Permissions { get; set; }
    }
}