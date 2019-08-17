using System;
using System.Collections.Generic;

namespace api.Models
{
    public partial class BudgetExpenditure
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public decimal? CurrentBudget { get; set; }
        public decimal? TotalExpenditure { get; set; }
        public decimal? Commitment { get; set; }
        public decimal? AvailableBudget { get; set; }
        public decimal? April { get; set; }
        public decimal? May { get; set; }
        public decimal? June { get; set; }
        public decimal? July { get; set; }
        public decimal? August { get; set; }
        public decimal? September { get; set; }
        public decimal? October { get; set; }
        public decimal? November { get; set; }
        public decimal? December { get; set; }
        public decimal? January { get; set; }
        public decimal? February { get; set; }
        public decimal? March { get; set; }
        public string ObjectiveLevel4 { get; set; }
        public string ProgrammeLevel5 { get; set; }
        public string SubProgrammeLevel6 { get; set; }
        public string ItemLevel3 { get; set; }
        public string ItemLevel4 { get; set; }
        public string ResponsibilityCode { get; set; }
        public string RegionalCode { get; set; }
        public string FundCode { get; set; }
        public string ObjectiveCode { get; set; }
        public string AssetsCode { get; set; }
        public string ProjectCode { get; set; }
        public string ItemCode { get; set; }
        public string InfrastructureCode { get; set; }
    }
}
