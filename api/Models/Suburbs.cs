using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class Suburbs
    {
        public int SuburbId { get; set; }
        public string SuburbCode { get; set; }
        public string SuburbName { get; set; }
        public string CityCode { get; set; }
    }
}
