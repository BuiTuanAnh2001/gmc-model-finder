using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPQCParamResultsBeforePhaseResponse
    {
        [JsonPropertyName("jobticketNo")]
        public string PPProductionOrdrNo { get; set; }
       [JsonPropertyName("qcParamResultID")]
        public int PPQCParamResultID { get; set; }
        [JsonPropertyName("qcParamResultNo")]
        public string PPQCParamResultNo { get; set; }
        [JsonPropertyName("qcParamResultName")]
        public string PPQCParamResultName { get; set; }
        [JsonPropertyName("qcParamResultDate")]
        public Nullable<DateTime> PPQCParamResultDate { get; set; }
        [JsonPropertyName("qcParamResultUser")]
        public string PPQCParamResultUser { get; set; }
        [JsonPropertyName("phaseNo")]
        public string PPPhaseCfgNo { get; set; }
        [JsonPropertyName("phaseName")]
        public string PPPhaseCfgName { get; set; }
        [JsonPropertyName("qcParamResultStatus")]
        public string PPQCParamResultStatus { get; set; }
        [JsonPropertyName("qcParamResultDesc")]
        public string PPQCParamResultDesc { get; set; }
        public decimal SL { get; set; }
    }
}
