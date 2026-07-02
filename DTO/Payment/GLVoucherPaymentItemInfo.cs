using System.Text.Json.Serialization;

namespace gmc_api.DTO.Payment
{
    public class GLVoucherPaymentItemInfo
    {
        [JsonPropertyName("objectType")]
        public string GLObjectTypes { get; set; }
        [JsonPropertyName("objectNo")]
        public string GLObjectNo { get; set; }
        [JsonPropertyName("objectName")]
        public string GLObjectName { get; set; }
        [JsonPropertyName("summaryF")]
        public decimal GLVoucherItemFAmtTot { get; set; }
        [JsonPropertyName("summary")]
        public decimal GLVoucherItemAmtTot { get; set; }
        [JsonPropertyName("description")]
        public string GLVoucherItemDesc { get; set; }
        public string taxNo { get; set; }
        public string taxName { get; set; }
        public decimal taxAmt { get; set; }
    }
}
