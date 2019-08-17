using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class Districts
    {
        public int DistrictId { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public string ProvinceCode { get; set; }
    }
}
