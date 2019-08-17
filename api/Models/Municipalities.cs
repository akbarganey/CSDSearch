using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class Municipalities
    {
        public int MunicipalityId { get; set; }
        public string MunicipalityCode { get; set; }
        public string MunicipalityName { get; set; }
        public string DistrictCode { get; set; }
    }
}
