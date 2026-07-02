using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ICProductsCreateRequest
    {
        [JsonPropertyName("toolId")]
        public int ICProductID { get; set; }
        [JsonPropertyName("toolSatus")]
        public string ICProductToolStatusCombo { get; set; }
    }
}
