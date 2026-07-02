using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Shipment
{
    public class ShipmentSeachFromPrdRst : Paging
    {

        [JsonPropertyName("no")]
        public string PPProductionOrdrNo { get; set; }

        [JsonPropertyName("branchId")]
        public int FK_BRBranchID { get; set; } = 0;

        [JsonPropertyName("workOrderId")]
        public int FK_PPWOID { get; set; } = 0;
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; } = 0;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = null;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = null;//Date
    }
}
