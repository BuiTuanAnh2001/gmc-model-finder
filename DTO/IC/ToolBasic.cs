using System;
using System.Text.Json.Serialization;

namespace gmc_api.Base.dto
{
    public class ToolBasic
    {
        [JsonPropertyName("productId")]
        public int ICProductID { get; set; }
        [JsonPropertyName("productNo")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("productName")]
        public string ICProductName { get; set; }
        [JsonPropertyName("toolStatus")]  
        public string ICProductToolStatusCombo { get; set; }
        [JsonPropertyName("atrophyQty")]
        public decimal ICProductNormAtrophyQty { get; set; }
        [JsonPropertyName("atrophyTimeQty")]
        public decimal ICProductNormAtrophyTimeQty { get; set; }
        [JsonPropertyName("atrophyRQty")]
        public decimal ICProductNormAtrophyRQty { get; set; }
        [JsonPropertyName("atrophyRTimeQty")]
        public decimal ICProductNormAtrophyRTimeQty { get; set; }
        public int useStatus { get; set; }
    }
}
