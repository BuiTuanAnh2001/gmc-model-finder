using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class RPTWOResponse
    {
        [JsonPropertyName("date")]
        public Nullable<DateTime> PPWODate { get; set; } 
        [JsonPropertyName("woNo")]
        public string PPWONo { get; set; }
        public List<RPTParamResponse> listParam { get; set; } = new List<RPTParamResponse>();

    }
}
