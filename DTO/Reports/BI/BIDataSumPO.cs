using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports
{
    public class BIDataSumPO
    {
        [JsonPropertyName("apPOPaymentOverdueDay")]
        public int APPOPaymentOverdueDay { get; set; }
        [JsonPropertyName("apPOAmtTot")]
        public decimal APPOAmtTot { get; set; }

    }
}
