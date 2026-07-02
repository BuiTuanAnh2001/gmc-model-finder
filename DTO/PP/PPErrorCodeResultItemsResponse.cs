using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPErrorCodeResultItemsResponse
    {
        [JsonPropertyName("errorCodeResultItemId")]
        public int PPErrorCodeResultItemID { get; set; }
        [JsonPropertyName("errorCodeId")]
        public int PPErrorCodeID { get; set; }
        [JsonPropertyName("errorCodeNo")]
        public string PPErrorCodeNo { get; set; }
        [JsonPropertyName("errorCodeName")]
        public string PPErrorCodeName { get; set; }
        [JsonPropertyName("note")]
        public string PPErrorCodeResultItemNote { get; set; }
        [JsonPropertyName("fgQty")]
        public decimal PPErrorCodeResultItemFGQty { get; set; }
        [JsonPropertyName("noneQty")]
        public decimal PPErrorCodeResultItemNoneQty { get; set; }
        [JsonPropertyName("desc")]
        public string PPErrorCodeResultItemDesc { get; set; }

    }
}
