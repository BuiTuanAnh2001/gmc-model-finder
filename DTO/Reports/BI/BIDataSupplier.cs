using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports
{
    public class BIDataSupplier
    {
        [JsonPropertyName("apSupplierNo")]
        public string APSupplierNo { get; set; }
        [JsonPropertyName("apSupplierName")]
        public string APSupplierName { get; set; }
        [JsonPropertyName("fk_APSupplierID")]
        public int FK_APSupplierID { get; set; }
        [JsonPropertyName("apPOItemAmtTot")]
        public decimal APPOItemAmtTot { get; set; }
    }
}
