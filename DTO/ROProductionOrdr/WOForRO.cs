using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class WOForRO
    {
        [JsonPropertyName("woId")]
        public int PPWOID { get; set; }
        [JsonPropertyName("woNo")]
        public string PPWONo { get; set; }
        [JsonPropertyName("desc")]
        public string PPWODesc { get; set; }
        [JsonPropertyName("woDate")]
        public Nullable<DateTime> PPWODate { get; set; }

    }
}
