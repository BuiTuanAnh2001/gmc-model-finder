using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PO
{
    public class POForReceiptInfo
    {
        [JsonPropertyName("nccId")]
        public int nccId { get; set; }
        [JsonPropertyName("nccName")]
        public string nccName { get; set; }
        [JsonPropertyName("id")]
        public int APPOID { get; set; }
        [JsonPropertyName("no")]
        public string APPONo { get; set; }
        [JsonPropertyName("apprDate")]
        public Nullable<DateTime> APPODate { get; set; }
        [JsonPropertyName("description")]
        public string APPODesc { get; set; }
        //   [JsonPropertyName("summary")]
    }
}
