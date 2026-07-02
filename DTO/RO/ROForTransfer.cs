using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.RO
{
    public class ROForTransfer
    {
        [JsonPropertyName("id")]
        public int ICROID { get; set; }
        [JsonPropertyName("no")]
        public string ICRONo { get; set; }
        [JsonPropertyName("roDate")]
        public Nullable<DateTime> ICRODate { get; set; }
        [JsonPropertyName("description")]
        public string ICRODesc { get; set; }
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; }
        [JsonPropertyName("woId")]
        public int FK_PPWOID { get; set; }
        [JsonPropertyName("jobTicketName")]
        public string jobTicketName { get; set; }
        [JsonPropertyName("fk_branch")]
        public int FK_BRBranchID { get; set; }
        public string PPWONo { get; set;}
    }
}
