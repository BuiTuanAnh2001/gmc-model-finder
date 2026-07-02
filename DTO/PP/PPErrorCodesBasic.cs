using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPErrorCodesBasic
    {
        [JsonPropertyName("errorCodeId")]
        public int PPErrorCodeID { get; set; }
        [JsonPropertyName("errorCodeNo")]
        public string PPErrorCodeNo{ get; set; }
        [JsonPropertyName("errorCodeName")]
        public string PPErrorCodeName { get; set; }

    }
}
