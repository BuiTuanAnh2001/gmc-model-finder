using System;
using System.Text.Json.Serialization;

namespace gmc_api.Base.dto
{
    public class ReceiptSearcPurchase : Paging
    {
        [JsonPropertyName("type")]
        public string type { get; set; } = "fromPo";
        [JsonPropertyName("no")]
        public string no { get; set; }
        [JsonPropertyName("nccId")]
        public int nccId { get; set; } = 0;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = null;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = null;
        public UserLoginInfo userInfo { get; set; } = new UserLoginInfo();
    }
}
