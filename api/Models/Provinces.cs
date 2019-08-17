using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class Provinces
    {
        public int ProvinceId { get; set; }
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public string CountryCode { get; set; }
    }
}
