using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class RPTParamResponse
    {
        [JsonPropertyName("paramId")]
        public int PPResourceParamID { get; set; }
        [JsonPropertyName("paramNo")]
        public string PPResourceParamNo { get; set; }
        [JsonPropertyName("paramName")]
        public string PPResourceParamName { get; set; }
        [JsonPropertyName("paramValue")]
        public string PPResourceParamItemValue { get; set; }
        [JsonPropertyName("defaultValue")]
        public string PPResourceParamDefaultValue { get; set; }
    }
}
