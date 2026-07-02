using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class RPTWOBasic
    {
        [JsonPropertyName("woid")]
        public int PPWOID { get; set; }
        [JsonPropertyName("date")]
        public Nullable<DateTime> PPWODate { get; set; } 
        [JsonPropertyName("woNo")]
        public string PPWONo { get; set; }

    }
}
