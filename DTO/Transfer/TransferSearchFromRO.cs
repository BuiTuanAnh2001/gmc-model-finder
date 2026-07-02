using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Transfer
{
    public class TransferSearchFromRO
    {
        [JsonPropertyName("no")]
        public string ICRONo { get; set; }
        [JsonPropertyName("woId")]
        public int FK_PPWOID { get; set; } = 0;
        [JsonPropertyName("jobId")]
        public int FK_PPProductionOrdrID { get; set; } = 0;
        [JsonPropertyName("checkReset")]
        public bool checkReset { get; set; } = false;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = null;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = null;//ICRODate
    }
}
