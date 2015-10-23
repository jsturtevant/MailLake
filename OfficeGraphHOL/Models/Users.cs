using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficeGraphHOL.Models.Users
{

    public class Rootobject
    {
        public string odatacontext { get; set; }
        public string odatatype { get; set; }
        public string odataid { get; set; }
        public string objectType { get; set; }
        public string objectId { get; set; }
        public object deletionTimestamp { get; set; }
        public bool accountEnabled { get; set; }
        public Assignedlicens[] assignedLicenses { get; set; }
        public Assignedplan[] assignedPlans { get; set; }
        public object city { get; set; }
        public object country { get; set; }
        public string department { get; set; }
        public bool dirSyncEnabled { get; set; }
        public string displayName { get; set; }
        public object facsimileTelephoneNumber { get; set; }
        public string givenName { get; set; }
        public string immutableId { get; set; }
        public string jobTitle { get; set; }
        public DateTime lastDirSyncTime { get; set; }
        public string mail { get; set; }
        public string mailNickname { get; set; }
        public string mobile { get; set; }
        public string onPremisesSecurityIdentifier { get; set; }
        public object[] otherMails { get; set; }
        public object passwordPolicies { get; set; }
        public object passwordProfile { get; set; }
        public string physicalDeliveryOfficeName { get; set; }
        public object postalCode { get; set; }
        public object preferredLanguage { get; set; }
        public Provisionedplan[] provisionedPlans { get; set; }
        public object[] provisioningErrors { get; set; }
        public string[] proxyAddresses { get; set; }
        public string sipProxyAddress { get; set; }
        public object state { get; set; }
        public object streetAddress { get; set; }
        public string surname { get; set; }
        public string telephoneNumber { get; set; }
        public string usageLocation { get; set; }
        public string userPrincipalName { get; set; }
        public object userType { get; set; }
    }

    public class Assignedlicens
    {
        public string[] disabledPlans { get; set; }
        public string skuId { get; set; }
    }

    public class Assignedplan
    {
        public DateTime assignedTimestamp { get; set; }
        public string capabilityStatus { get; set; }
        public string service { get; set; }
        public string servicePlanId { get; set; }
    }

    public class Provisionedplan
    {
        public string capabilityStatus { get; set; }
        public string provisioningStatus { get; set; }
        public string service { get; set; }
    }

}