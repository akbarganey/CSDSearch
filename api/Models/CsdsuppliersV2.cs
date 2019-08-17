using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class CsdsuppliersV2
    {
        public int SupplierId { get; set; }
        public string SupplierNumber { get; set; }
        public string IsActive { get; set; }
        public string LegalName { get; set; }
        public string TradingName { get; set; }
        public string IdtypeCode { get; set; }
        public string SupplierType { get; set; }
        public string SupplierSubType { get; set; }
        public string RestrictedSupplier { get; set; }
        public string GovernmentEmployee { get; set; }
        public string CompanyReg { get; set; }
        public string CreatedDate { get; set; }
        public string EditDate { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactCellphoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string CountryName { get; set; }
        public string ProvinceName { get; set; }
        public string DistrictName { get; set; }
        public string MunicipalityName { get; set; }
        public string CityName { get; set; }
        public string SuburbName { get; set; }
        public string WardName { get; set; }
        public string PostalCode { get; set; }
        public string ValidAddress { get; set; }
        public string BankAccountTypeCode { get; set; }
        public string BankName { get; set; }
        public string BranchNumber { get; set; }
        public string AccountNumber { get; set; }
        public string BankAccountStatusCode { get; set; }
        public string SourceFile { get; set; }
        public int? IntegrationId { get; set; }
        public string IsValidCertificate { get; set; }
    }
}
