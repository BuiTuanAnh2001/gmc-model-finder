using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class SearchRequestReceiptsResponses
    {
        [JsonPropertyName("id")]
        public int ICRequestReceiptID { get; set; }
        [JsonPropertyName("no")]
        public string ICRequestReceiptNo { get; set; }
        [JsonPropertyName("date")]
        public Nullable<DateTime> ICRequestReceiptDate { get; set; }
        [JsonPropertyName("desc")]
        public string ICRequestReceiptDesc { get; set; }
        [JsonPropertyName("approvalstatus")]
        public string ApprovalStatusCombo { get; set; }
        [JsonPropertyName("stockid")]
        public int ICStockID { get; set; }
        [JsonPropertyName("stockno")]
        public string ICStockNo { get; set; }
        [JsonPropertyName("stockname")]
        public string ICStockName { get; set; }
    }
}
