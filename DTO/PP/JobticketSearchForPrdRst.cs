using gmc_api.Base.Helpers;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class JobticketSearchForPrdRst
    {
        [JsonPropertyName("no")]
        public string PPProductionOrdrNo { get; set; }
        [JsonPropertyName("branchId")]
        public int FK_BRBranchID { get; set; }
        [JsonPropertyName("woId")]
        public int FK_PPWOID { get; set; }
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; }
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = null;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = null;//Date
    }
}
