using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class WalkerIndex
    {
        public int Id { get; set; }
        public string VendorCode { get; set; }
        public string LegalName { get; set; }
        public string TradingName { get; set; }
        public string TelNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string AddressLine5 { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string Status { get; set; }
        public string BankName { get; set; }
        public string BranchNumber { get; set; }
        public string AccountNumber { get; set; }
        public string HoldingCompany { get; set; }
        public string CreatedDate { get; set; }
        public string ShortName { get; set; }
        public string CompanyReg { get; set; }
        public string Editdate { get; set; }
        public string AccountTypeCode { get; set; }
        public string SupplierNumber { get; set; }
        public string Email { get; set; }
        public string IdtypeCode { get; set; }
        public string IndustryClassification { get; set; }
        public string InterfaceStatus { get; set; }
        public string InterfaceStatusDate { get; set; }
        public int? IntegrationId { get; set; }
    }
}
