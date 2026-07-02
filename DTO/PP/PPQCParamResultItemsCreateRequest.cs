using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPQCParamResultItemsCreateRequest
    {
        [JsonPropertyName("qcParamResultItemId")]
        public int PPQCParamResultItemID { get; set; }
        [JsonPropertyName("qcParamResultId")]
        public int FK_PPQCParamResultID { get; set; }
        [JsonPropertyName("qcParamId")]
        public int FK_PPQCParamID { get; set; }
        [JsonPropertyName("minValue")]
        public decimal PPQCParamResultItemMinValue { get; set; }
        [JsonPropertyName("maxValue")]
        public decimal PPQCParamResultItemMaxValue { get; set; }
        [JsonPropertyName("value")]
        public string PPQCParamResultItemValue { get; set; }
        [JsonPropertyName("interMinValue")]
        public decimal PPQCParamResultItemInternalMinValue { get; set; }
        [JsonPropertyName("interMaxValue")]
        public decimal PPQCParamResultItemInternalMaxValue { get; set; }
        [JsonPropertyName("defaultValue")]
        public string PPQCParamResultItemDefaultValue { get; set; }
        [JsonPropertyName("rollNumber")]
        public decimal PPQCParamResultItemRollNumber { get; set; }
        [JsonPropertyName("desc")]
        public string PPQCParamResultItemDesc { get; set; }
    }
}
