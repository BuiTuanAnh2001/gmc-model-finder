using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPErrorCodeResultsBeforePhaseResponse
    {
        [JsonPropertyName("jobticketNo")]
        public string PPProductionOrdrNo { get; set; }
        [JsonPropertyName("errorCodeResultId")]
        public int PPErrorCodeResultID { get; set; }
        [JsonPropertyName("errorCodeResultNo")]
        public string PPErrorCodeResultNo { get; set; }
        [JsonPropertyName("errorCodeResultName")]
        public string PPErrorCodeResultName { get; set; }
        [JsonPropertyName("errorCodeResultDate")]
        public Nullable<DateTime> PPErrorCodeResultDate { get; set; }
        [JsonPropertyName("errorCodeResultUser")]
        public string PPErrorCodeResultUser { get; set; }
        [JsonPropertyName("phaseNo")]
        public string PPPhaseCfgNo { get; set; }
        [JsonPropertyName("phaseName")]
        public string PPPhaseCfgName { get; set; }
        [JsonPropertyName("errorCodeResultStatus")]
        public string PPErrorCodeResultStatus { get; set; }
        [JsonPropertyName("errorCodeResultDesc")]
        public string PPErrorCodeResultDesc { get; set; }
        public decimal SL { get; set; }
    }
}
