using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class ReportResourceParamMasterResponse
    {
        [JsonPropertyName("productID")]
        public int ICProductID { get; set; }
        [JsonPropertyName("productNo")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("productName")]
        public string ICProductName { get; set; }

        [JsonPropertyName("resourceID")]
        public int PPResourceID { get; set; }
        [JsonPropertyName("resourceNo")]
        public string PPResourceNo { get; set; }
        [JsonPropertyName("resourceName")]
        public string PPResourceName { get; set; }

        [JsonPropertyName("resourceParamId")]
        public int PPResourceParamID { get; set; }
        [JsonPropertyName("resourceParamNo")]
        public string PPResourceParamNo { get; set; }
        [JsonPropertyName("resourceParamName")]
        public string PPResourceParamName { get; set; }
        public string defaultValue { get; set; }
        public string lastValue { get; set; }


    }
}
