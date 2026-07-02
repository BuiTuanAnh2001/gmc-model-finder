using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class RequestReceiptForReceiptInfo
    {
        [JsonPropertyName("id")]
        public int ICRequestReceiptID { get; set; }
        [JsonPropertyName("no")]
        public string ICRequestReceiptNo { get; set; }
        [JsonPropertyName("requestDate")]
        public Nullable<DateTime> ICRequestReceiptDate { get; set; }
        [JsonPropertyName("statusCombo")]
        public string ICRequestReceiptStatusCombo { get; set; }
        [JsonPropertyName("description")]
        public string ICRequestReceiptDesc { get; set; }
        [JsonPropertyName("nccNo")]
        public string nccNo { get; set; }
        [JsonPropertyName("nccName")]
        public string nccName { get; set; }
        public int FK_APSupplierID { get; set; }
        public int FK_ICStockID { get; set; }
    }
}
