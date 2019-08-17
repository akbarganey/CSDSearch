using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class Commodities
    {
        public int CommodityId { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public int? ClassId { get; set; }
    }
}
