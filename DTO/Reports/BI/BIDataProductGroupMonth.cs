using gmc_api.Base.Helpers;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.Reports
{
    public class BIDataProductGroupMonth
    {
        [JsonPropertyName("icProductGroupNo")]
        public string ICProductGroupNo { get; set; }
        [JsonPropertyName("icProductGroupName")]
        public string ICProductGroupName { get; set; }
        [JsonPropertyName("apPODate")]
        public Nullable<DateTime> APPODate { get; set; }
        [JsonPropertyName("apPOItemAmtTot")]
        public decimal APPOItemAmtTot { get; set; }
    }
}
