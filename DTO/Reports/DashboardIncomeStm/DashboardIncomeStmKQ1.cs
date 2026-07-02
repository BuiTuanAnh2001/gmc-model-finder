using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardIncomeStm
{
    public class DashboardIncomeStmKQ1
    {
        [JsonPropertyName("_RevAmt")]
        public decimal RevAmt { get; set; }
        [JsonPropertyName("_COGSAmt")]
        public decimal COGSAmt { get; set; }
        [JsonPropertyName("_ProfitAmt")]
        public decimal ProfitAmt { get; set; }
        [JsonPropertyName("_LNTAmt")]
        public decimal LNTAmt { get; set; }
        [JsonPropertyName("_LNSTAmt")]
        public decimal LNSTAmt { get; set; }
        [JsonPropertyName("_ProfitPct")]
        public decimal ProfitPct { get; set; }
        [JsonPropertyName("_EBITPct")]
        public decimal EBITPct { get; set; }
        [JsonPropertyName("_EBITADPct")]
        public decimal EBITADPct { get; set; }
        [JsonPropertyName("_NetProfitAmt")]
        public decimal NetProfitAmt { get; set; }
        [JsonPropertyName("_NetProfitPct")]
        public decimal NetProfitPct { get; set; }

    }
}
