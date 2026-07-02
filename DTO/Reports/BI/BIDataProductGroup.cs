using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports
{
    public class BIDataProductGroup
    {
        [JsonPropertyName("icProductGroupNo")]
        public string ICProductGroupNo { get; set; }
        [JsonPropertyName("icProductGroupName")]
        public string ICProductGroupName { get; set; }
        [JsonPropertyName("apPOItemAmtTot")]
        public decimal APPOItemAmtTot { get; set; }
    }
}
