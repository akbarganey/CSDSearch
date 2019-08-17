using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class IntegrationLog
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string DateProcessed { get; set; }
        public int? RecordsProcessed { get; set; }
        public string DateIndexed { get; set; }
        public int? RecordsIndexed { get; set; }
        public string DateInterfaced { get; set; }
        public int? RecordsInterfaced { get; set; }
    }
}
