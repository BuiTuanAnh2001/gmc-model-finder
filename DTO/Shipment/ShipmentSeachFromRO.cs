using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Shipment
{
    public class ShipmentSeachFromRO : Paging
    {
        [JsonPropertyName("arSOId")]
        public int FK_ARSOID { get; set; } = 0;
        [JsonPropertyName("branchId")]
        public int FK_BRBranchID { get; set; } = 0;
        [JsonPropertyName("no")]
        public string ICRONo { get; set; }
        [JsonPropertyName("customerId")]
        public int FK_ARCustomerID { get; set; } = 0;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = null;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = null;//ICRODate
        [JsonPropertyName("fromShipmenntDate")]
        public Nullable<DateTime> fromShipmenntDate { get; set; } = null;
        [JsonPropertyName("toShipmenntDate")]
        public Nullable<DateTime> toShipmenntDate { get; set; } = null;//ICROItemShpDate
        [JsonPropertyName("SearchModule")]
        public string AAModule { get; set; } = "RO";
    }
}
