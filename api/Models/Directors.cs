using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class Directors
    {
        public int DirectorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Idnumber { get; set; }
        public string Employee { get; set; }
        public string SupplierNumber { get; set; }
        public string IsActive { get; set; }
        public string DirectorStatusTypeCode { get; set; }
    }
}
