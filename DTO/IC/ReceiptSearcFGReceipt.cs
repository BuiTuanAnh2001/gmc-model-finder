using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ReceiptSearcFGReceipt : Paging
    {
        [JsonPropertyName("type")]
        public string type { get; set; } = "fromPrdRst";
        [JsonPropertyName("no")]
        public string no { get; set; }
        [JsonPropertyName("branchId")]
        public int branchId { get; set; } = 0;
        [JsonPropertyName("phaseId")]
        public int phaseId { get; set; } = 0;
        [JsonPropertyName("nccId")]
        public int nccId { get; set; } = 0;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = null;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = null;
        public UserLoginInfo userInfo { get; set; } = new UserLoginInfo();
    }
}
