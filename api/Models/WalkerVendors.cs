using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class WalkerVendors
    {
        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public string SupplierCode { get; set; }
        public string CompReg { get; set; }
        public string IdtypeCode { get; set; }
        public string VendorName { get; set; }
        public string Status { get; set; }
        public string Created { get; set; }
        public string Updated { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string BankCode { get; set; }
        public string AccountType { get; set; }
        public string BranchCode { get; set; }
        public string AccountNumber { get; set; }
        public string TelNo { get; set; }
    }
}
