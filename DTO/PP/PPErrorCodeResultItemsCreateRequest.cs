using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPErrorCodeResultItemsCreateRequest
    {

        [JsonPropertyName("errorCodeResultId")]
        public int FK_PPErrorCodeResultID { get; set; }
        [JsonPropertyName("errorCodeResultItemId")]
        public int PPErrorCodeResultItemID { get; set; }
        [JsonPropertyName("errorCodeId")]
        public int FK_PPErrorCodeID { get; set; }
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

