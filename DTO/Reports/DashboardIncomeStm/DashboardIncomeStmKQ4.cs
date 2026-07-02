using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardIncomeStm
{
    public class DashboardIncomeStmKQ4
    {
        [JsonPropertyName("_Argument")]
        public string Argument { get; set; }
        [JsonPropertyName("_RevAmt")]
        public decimal RevAmt { get; set; }
        [JsonPropertyName("_ProfitAmt")]
        public decimal ProfitAmt { get; set; }
        [JsonPropertyName("_NetProfitAmt")]
        public decimal NetProfitAmt { get; set; }
        [JsonPropertyName("_ProfitPct")]
        public decimal ProfitPct { get; set; }
        [JsonPropertyName("_NetProfitPct")]
        public decimal NetProfitPct { get; set; }
    }
}
