using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;
using gmc_api.DTO.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ProOrdrForROInfo
    {
        [JsonPropertyName("jobticketId")]
        public int PPProductionOrdrID { get; set; }
        [JsonPropertyName("woId")]
        public int FK_PPWOID { get; set; }
        [JsonPropertyName("brBranchID")]
        public int FK_BRBranchID { get; set; }
    }
}
