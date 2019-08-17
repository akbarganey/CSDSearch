using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class Cities
    {
        public int CityId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string MunicipalityCode { get; set; }
    }
}
