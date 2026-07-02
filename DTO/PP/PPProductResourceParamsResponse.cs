using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPProductResourceParamsResponse
    {
        [JsonPropertyName("productResourceParamId")]
        public int PPProductResourceParamID { get; set; }
        [JsonPropertyName("resourceParamId")]
        public int FK_PPResourceParamID { get; set; }
        [JsonPropertyName("resourceParamNo")]
        public string PPResourceParamNo { get; set; }
        [JsonPropertyName("resourceParamName")]
        public string PPResourceParamName { get; set; }
        [JsonPropertyName("ResourceID")]
        public int FK_PPResourceID { get; set; }
        [JsonPropertyName("productGroupId")]
        public int FK_ICProductGroupID { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("resourceParamValue")]
        public String PPProductResourceParamValue { get; set; }
        [JsonPropertyName("productResourceParamCheck")]
        public bool PPProductResourceParamCheck { get; set; }
        [JsonPropertyName("resourceParamMinValue")]
        public decimal PPProductResourceParamMinValue { get; set; }
        [JsonPropertyName("resourceParamMaxValue")]
        public decimal PPProductResourceParamMaxValue { get; set; }


    }
}
