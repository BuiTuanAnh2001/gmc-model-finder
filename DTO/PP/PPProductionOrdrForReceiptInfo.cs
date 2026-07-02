using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPProductionOrdrForReceiptInfo
    {
        [JsonPropertyName("id")]
        public int PPProductionOrdrID { get; set; }
        [JsonPropertyName("no")]
        public string PPProductionOrdrNo { get; set; }
        [JsonPropertyName("jobticketNo")]
        public string jobticketNo { get; set; }
        [JsonPropertyName("woNo")]
        public string woNo { get; set; }
        [JsonPropertyName("proOrderDate")]
        public Nullable<DateTime> PPProductionOrdrDate { get; set; }
        [JsonPropertyName("description")]
        public string PPProductionOrdrDesc { get; set; }
        //   [JsonPropertyName("summary")]
    }
}
