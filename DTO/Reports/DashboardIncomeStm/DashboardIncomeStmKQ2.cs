using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardIncomeStm
{
    public class DashboardIncomeStmKQ2
    {
        [JsonPropertyName("_IncomeID")]
        public int IncomeID { get; set; }
        [JsonPropertyName("_IncomeSign")]
        public int IncomeSign { get; set; }
        [JsonPropertyName("_IncomeYear")]
        public string IncomeYear { get; set; }
        [JsonPropertyName("_IncomeName")]
        public string IncomeName { get; set; }
        [JsonPropertyName("_IncomeAmt")]
        public decimal IncomeAmt { get; set; }
    }
}
