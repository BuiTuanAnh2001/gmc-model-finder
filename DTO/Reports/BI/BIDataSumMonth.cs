using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;
using System;
namespace gmc_api.DTO.Reports
{
    public class BIDataSumMonth
    {
        [JsonPropertyName("apPODate")]
        public Nullable<DateTime> APPODate { get; set; }
        [JsonPropertyName("apPOItemAmtTot")]
        public decimal APPOItemAmtTot { get; set; }
    }
}
