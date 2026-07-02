using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports
{
    public class BIDataProduct
    {
        [JsonPropertyName("icProductNo")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("icProductName")]
        public string ICProductName { get; set; }
        [JsonPropertyName("fk_ICProductID")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("apPOItemAmtTot")]
        public decimal APPOItemAmtTot { get; set; }
    }
}
