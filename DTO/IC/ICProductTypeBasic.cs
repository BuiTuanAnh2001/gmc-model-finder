using System;
using System.Text.Json.Serialization;

namespace gmc_api.Base.dto
{
    public class ICProductTypeBasic
    {
        [JsonPropertyName("productTypeId")]
        public int ICProductTypeID { get; set; }
        [JsonPropertyName("productTypeNo")]
        public string ICProductTypeNo { get; set; }
        [JsonPropertyName("productTypeName")]
        public string ICProductTypeName { get; set; }
    }
}
