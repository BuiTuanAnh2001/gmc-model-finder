using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports
{
    public class BIDataPO
    {
        [JsonPropertyName("apPONo")]
        public string APPONo { get; set; }
        [JsonPropertyName("fk_APPOID")]
        public int FK_APPOID { get; set; }
        [JsonPropertyName("apPODate")]
        public Nullable<DateTime> APPODate { get; set; }
        [JsonPropertyName("apPOItemAmtTot")]
        public decimal APPOItemAmtTot { get; set; }
    }
}
