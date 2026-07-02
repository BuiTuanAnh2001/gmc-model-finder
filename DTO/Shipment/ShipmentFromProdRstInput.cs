using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Shipment
{
    public class ShipmentFromProdRstInput
    {
        public int transConfgId { get; set; }
        public int transOrgConfigId { get; set; }
        public int employeeId { get; set; }
        public int branchId { get; set; }
        public int currencyId { get; set; }
        public string description { get; set; }
        public Nullable<DateTime> shipDate { get; set; }
        public string no { get; set; }
        public int stockId { get; set; }
        public int shipmentTypeId { get; set; }
        public bool isPassWaringStock { get; set; } = false;
        public string prdRstListID { get; set; }
        [JsonPropertyName("items")]
        public List<ShipmentItemFromInput> items { get; set; }
    }
}
