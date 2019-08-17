using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class WalkerOrderHeaders
    {
        public int Id { get; set; }
        public string VendorCode { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? CaptureDate { get; set; }
        public DateTime? AuthDate { get; set; }
        public string Status { get; set; }
        public decimal? GrossValue { get; set; }
        public decimal? PaidValue { get; set; }
    }
}
