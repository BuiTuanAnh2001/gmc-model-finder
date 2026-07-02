using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports
{
    public class BIDataEmployee
    {
        [JsonPropertyName("hrEmployeeNo")]
        public string HREmployeeNo { get; set; }
        [JsonPropertyName("hrEmployeeName")]
        public string HREmployeeName { get; set; }
        [JsonPropertyName("fk_ICProductID")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("apPOItemAmtTot")]
        public decimal APPOItemAmtTot { get; set; }
    }
}
