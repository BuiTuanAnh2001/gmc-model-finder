using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class QCParamMappingsBasic
    {
        [JsonPropertyName("paramId")]
        public int PPQCParamID { get; set; }
        [JsonPropertyName("paramNo")]
        public string PPQCParamNo { get; set; }
        [JsonPropertyName("paramName")]
        public string PPQCParamName { get; set; }
        [JsonPropertyName("minValue")]
        public decimal PPQCParamMappingMinValue { get; set; }
        [JsonPropertyName("maxValue")]
        public decimal PPQCParamMappingMaxValue { get; set; }
        [JsonPropertyName("interMinValue")]
        public decimal PPQCParamMappingInternalMinValue { get; set; }
        [JsonPropertyName("interMaxValue")]
        public decimal PPQCParamMappingInternalMaxValue { get; set; }
        [JsonPropertyName("defaultValue")]
        public string PPQCParamDefaultValue { get; set; }
        [JsonPropertyName("customerID")]
        public int ARCustomerID { get; set; }
        [JsonPropertyName("customerNo")]
        public string ARCustomerNo { get; set; }
        [JsonPropertyName("customerName")]
        public string ARCustomerName { get; set; }
    }
}
