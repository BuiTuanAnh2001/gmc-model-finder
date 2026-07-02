using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardIncomeStm
{
    public class DashboardIncomeStmKQ3
    {
        [JsonPropertyName("_Argument")]
        public string Argument { get; set; }
        [JsonPropertyName("_CostAmt")]
        public decimal CostAmt { get; set; }
        [JsonPropertyName("_CostPct")]
        public decimal CostPct { get; set; }
        [JsonPropertyName("_Index")]
        public int Index { get; set; }
    }
}
