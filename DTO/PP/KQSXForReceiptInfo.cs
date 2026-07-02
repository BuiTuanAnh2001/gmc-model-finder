using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class KQSXForReceiptInfo
    {
        [JsonPropertyName("id")]
        public int PPProductionOrdrID { get; set; }
        [JsonPropertyName("no")]
        public string PPProductionOrdrNo { get; set; }

        [JsonPropertyName("jobticketNo")]
        public string jobticketNo { get; set; }
        [JsonPropertyName("woName")]
        public string woName { get; set; }
        [JsonPropertyName("prdOrdrDate")]
        public Nullable<DateTime> PPProductionOrdrDate { get; set; }
        [JsonPropertyName("description")]
        public string PPProductionOrdrDesc { get; set; }
        //   [JsonPropertyName("summary")]
        public int FK_PPPhaseCfgID { get; set; }
        public string PPPhaseCfgNo { get; set; }
        public string PPPhaseCfgName { get; set; }
    }
}
