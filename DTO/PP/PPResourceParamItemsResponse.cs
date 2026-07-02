using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPResourceParamItemsResponse
    {
        [JsonPropertyName("resourceParamItemId")]
        public int PPResourceParamItemID { get; set; }
        [JsonPropertyName("resourceParamId")]
        public int FK_PPResourceParamID { get; set; }
        [JsonPropertyName("resourceParamNo")]
        public string PPResourceParamNo { get; set; }
        [JsonPropertyName("resourceParamName")]
        public string PPResourceParamName { get; set; }
        [JsonPropertyName("resourceParamItemDftValue")]
        public String PPResourceParamItemDftValue { get; set; }
        [JsonPropertyName("resourceParamItemLastValue")]
        public String PPResourceParamItemLastValue { get; set; }
        [JsonPropertyName("resourceParamItemValue")]
        public String PPResourceParamItemValue { get; set; }
        [JsonPropertyName("productionOrdrEstFGId")]
        public int FK_PPProductionOrdrEstFGID { get; set; }
        [JsonPropertyName("resourceParamItemCheck")]
        public bool PPResourceParamItemCheck { get; set; }
        [JsonPropertyName("resourceParamItemNote")]
        public string PPResourceParamItemNote { get; set; }
        [JsonPropertyName("resourceParamItemMinValue")]
        public decimal PPResourceParamItemMinValue { get; set; }
        [JsonPropertyName("resourceParamItemMaxValue")]
        public decimal PPResourceParamItemMaxValue { get; set; }
    }
}
