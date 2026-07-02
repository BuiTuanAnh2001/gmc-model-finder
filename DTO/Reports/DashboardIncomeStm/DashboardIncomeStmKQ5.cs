using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardIncomeStm
{
    public class DashboardIncomeStmKQ5
    {
        [JsonPropertyName("_Argument")]
        public string Argument { get; set; }
        [JsonPropertyName("_NetProfitAmt")]
        public decimal NetProfitAmt { get; set; }
        
    }
}
