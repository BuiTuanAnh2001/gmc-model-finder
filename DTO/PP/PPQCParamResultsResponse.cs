using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPQCParamResultsResponse
    {
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
        [JsonPropertyName("qcParamResultStatus")]
        public string PPQCParamResultStatus { get; set; }
        [JsonPropertyName("qcParamResultDesc")]
        public string PPQCParamResultDesc { get; set; }
    }
}
